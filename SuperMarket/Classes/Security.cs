using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using SuperMarket;

namespace SuperMarket.Classes
{
    class Security
    {
        private static readonly string ApplicationName = "Super Market System",
            DriveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
            DirectoryLocation = $@"{DriveLetter}Users\{Environment.UserName}\AppData\Local\{ApplicationName}",
            SerialKeyFileName = @"\serial",
            FileExtention = ".enc",
            SerialKeyFile = DirectoryLocation + SerialKeyFileName + FileExtention;

        public static string CPUID = "", MOBOID = "";

        public static bool OpenFormMain = false;

        public static string GetDirecotryLocation()
        {
            return DirectoryLocation;
        }

        public static string CheckLicenseKeyOnApp()
        {
            if (CPUID == "" && MOBOID == "")
            {
                CPUID = GetCpuID();
                MOBOID = GetMotherBoardID();
            }

            SerialKeyFileExists();

            if (new FileInfo(SerialKeyFile).Length == 0)

            {
                Logger.Log("serial file exists with no serial in it", "CheckSerialKeyOnApp", "LoginMethods", Logger.CRITICAL);
                return "404";
            }

            if (Properties.Settings.Default.LicenseKey == Security.Decrypt(File.ReadAllText(SerialKeyFile), CPUID + MOBOID))
            {
                Logger.Log("serial key matched on system", "CheckSerialKeyOnApp", "LoginMethods", Logger.INFO);
                return "200";
            }

            else
            {
                Logger.Log("wrong serial on app", "CheckSerialKeyOnApp", "LoginMethods", Logger.ERROR);
                return "400";
            }
        }

        public static void SaveLicenseKeyInApp(string LicenseKey)
        {
            Logger.Log("Entered the serial key & saved it in the app", "EnterSerialKey", "LoginMethods", Logger.INFO);
            Properties.Settings.Default.LicenseKey = LicenseKey;
            Properties.Settings.Default.Save();
        }

        public static string CheckLicenseKeyValidity(string LicenseKey)
        {
            if (CPUID == "" && MOBOID == "")
            {
                CPUID = GetCpuID();
                MOBOID = GetMotherBoardID();
            }

            SerialKeyFileExists();

            if (new FileInfo(SerialKeyFile).Length == 0)
            {
                Logger.Log("serial file exists with no serial in it", "CheckSerialKeyOnApp", "LoginMethods", Logger.CRITICAL);
                return "404";
            }

            if (LicenseKey == Security.Decrypt(File.ReadAllText(SerialKeyFile), CPUID + MOBOID))
            {
                Logger.Log("serial key matched on system", "CheckSerialKeyOnApp", "LoginMethods", Logger.INFO);
                return "200";
            }

            else
            {
                Logger.Log("wrong serial on app", "CheckSerialKeyOnApp", "LoginMethods", Logger.ERROR);
                return "400";
            }
        }

        internal static bool SerialKeyFileExists()
        {
            bool state = true;

            if (!Directory.Exists(DirectoryLocation))
            {
                Directory.CreateDirectory(DirectoryLocation);
                Logger.Log("created the directory for the serial", "SerialKeyFileExists", "LoginMethods", Logger.CRITICAL);
            }

            if (!File.Exists(DirectoryLocation + SerialKeyFileName + FileExtention))
            {
                Logger.Log("serial key file doesnt exist & created a new one", "LoginMethods", "SerialKeyFileExists", Logger.CRITICAL);
                state = false;
                //File.Create(DirectoryLocation + SerialKeyFileName + FileExtention).Close();
            }

            return state;
        }

        #region Motherboard & CPU methods

        private static string GetMotherBoardID()
        {
            string serial = "";
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                ManagementObjectCollection moc = mos.Get();

                foreach (ManagementObject mo in moc)
                {
                    serial = mo["SerialNumber"].ToString();
                }
                return serial;
            }
            catch (Exception) { return serial; }
        }

        private static string GetCpuID()
        {
            ManagementClass management = new ManagementClass("win32_processor");
            ManagementObjectCollection managementObjectCollection = management.GetInstances();

            foreach (var managementObject in managementObjectCollection)
            {
                var cpuid = managementObject.Properties["processorID"].Value.ToString();
                return cpuid;
            }

            return "";
        }

        #endregion

        #region encryption and decryption
        internal const int Keysize = 128;
        internal const int DerivationIterations = 1000;
        internal static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[16];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        internal static string Encrypt(string plainText, string passPhrase)
        {
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        internal static string Decrypt(string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            var plainTextBytes = new byte[cipherTextBytes.Length];
                            var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                            memoryStream.Close();
                            cryptoStream.Close();
                            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                        }

                    }
                }
            }
        }

        #endregion
    }
}
