using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes
{
    class Security
    {
        private static readonly string ApplicationName = "Super Market System",
            DatabaseName = "SuperMarket",
            DriveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
            DirectoryLocation = $@"{DriveLetter}Users\{Environment.UserName}\AppData\Local\{ApplicationName}",
            SerialKeyFileName = @"\serial",
            FileExtention = ".enc",
            SerialKeyFileLocation = DirectoryLocation + SerialKeyFileName + FileExtention;

        public static string CPUID = "", MOBOID = "", CPUName = "", CPUCores = "", CPUSpeed = "", SystemName = "";

        public static bool OpenFormMain = false;

        public static string GetDBName()
        {
            return DatabaseName;
        }

        public static string GetDriveLetter()
        {
            return DriveLetter;
        }

        public static string GetSerialKeyFileLocation()
        {
            return SerialKeyFileLocation;
        }

        public static string GetDirecotryLocation()
        {
            return DirectoryLocation;
        }

        public async static Task<string> CheckLicenseKeyOnAppAsync()
        {
            await GetComputerInfo();

            await SerialKeyFileExistsAsync();

            if (new FileInfo(SerialKeyFileLocation).Length == 0)

            {
                Logger.Log("serial file exists with no serial in it",
                     System.Reflection.MethodInfo.GetCurrentMethod().Name, "Security", Logger.CRITICAL);
                return "404";
            }

            string LisenceKey = await Security.DecryptAsync(File.ReadAllText(SerialKeyFileLocation), CPUID + MOBOID);

            if (Properties.Settings.Default.LicenseKey == LisenceKey)
            {
                Logger.Log("serial key matched on system",
                     System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.INFO);
                return "200";
            }

            else
            {
                Logger.Log("wrong serial on app",
                   System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.ERROR);
                return "400";
            }
        }

        public static void SaveLicenseKeyInAppAsync(string LicenseKey)
        {
            Logger.Log("Entered the serial key & saved it in the app",
                    System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.INFO);
            Properties.Settings.Default.LicenseKey = LicenseKey;
            Properties.Settings.Default.Save();
        }

        public static async Task GetComputerInfo()
        {
            if (CPUID == "" && MOBOID == "")
            {
                CPUID = await Task.Run(() => GetCpuID());
                MOBOID = await Task.Run(() => GetMotherBoardIDAsync());
                CPUName = await Task.Run(() => GetCpuInfo("Name"));
                CPUCores = await Task.Run(() => GetCpuInfo("NumberOfCores"));
                CPUSpeed = await Task.Run(() => GetCpuInfo("CurrentClockSpeed"));
                SystemName = await Task.Run(() => GetCpuInfo("SystemName"));
            }
        }

        public async static Task<string> CheckLicenseKeyValidityAsync(string LicenseKey)
        {
            await GetComputerInfo();

            await SerialKeyFileExistsAsync();

            if (new FileInfo(SerialKeyFileLocation).Length == 0)
            {
                Logger.Log("serial file exists with no serial in it",
                     System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
                return "404";
            }

            string LisenceKeyChecker = await Security.DecryptAsync(File.ReadAllText(SerialKeyFileLocation), CPUID + MOBOID);

            if (LicenseKey == LisenceKeyChecker)
            {
                Logger.Log("serial key matched on system", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                   "LoginMethods", Logger.INFO);
                return "200";
            }

            else
            {
                Logger.Log("wrong serial on app", System.Reflection.MethodInfo.GetCurrentMethod().Name,
                   "LoginMethods", Logger.ERROR);
                return "400";
            }
        }

        internal async static Task<bool> SerialKeyFileExistsAsync()
        {
            bool state = true;

            if (!Directory.Exists(DirectoryLocation))
            {
                await Task.Run(() => Directory.CreateDirectory(DirectoryLocation));
                Logger.Log("created the directory for the serial", System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
            }

            if (!File.Exists(DirectoryLocation + SerialKeyFileName + FileExtention))
            {
                Logger.Log("serial key file doesnt exist & created a new one", System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
                state = false;
                //File.Create(DirectoryLocation + SerialKeyFileName + FileExtention).Close();
            }

            return state;
        }

        #region Computer information

        private async static Task<string> GetMotherBoardIDAsync()
        {
            string serial = "";
            try
            {
                ManagementObjectSearcher mos =
                    await Task.Run(() => new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard"));
                ManagementObjectCollection moc = await Task.Run(() => mos.Get());

                foreach (ManagementObject mo in moc)
                {
                    serial = await Task.Run(() => mo["SerialNumber"].ToString());
                }
                return serial;
            }
            catch (Exception) { return serial; }
        }

        private async static Task<string> GetCpuID()
        {
            ManagementClass management = await Task.Run(() => new ManagementClass("win32_processor"));
            ManagementObjectCollection managementObjectCollection = await Task.Run(() => management.GetInstances());

            foreach (var managementObject in managementObjectCollection)
            {
                var cpuid = await Task.Run(() => managementObject.Properties["processorID"].Value.ToString());
                return cpuid;
            }

            return "";
        }

        private async static Task<string> GetCpuInfo(string PropertyName)
        {
            ManagementClass management = await Task.Run(() => new ManagementClass("win32_processor"));
            ManagementObjectCollection managementObjectCollection = await Task.Run(() => management.GetInstances());

            foreach (var managementObject in managementObjectCollection)
            {
                string cpuName = await Task.Run(() => managementObject.Properties[PropertyName].Value.ToString().Trim());
                return cpuName.Trim();
            }

            return "";
        }

        public async static Task<string> GetSystemName()
        {
            ManagementClass management = await Task.Run(() => new ManagementClass("win32_processor"));
            ManagementObjectCollection managementObjectCollection = await Task.Run(() => management.GetInstances());

            foreach (var managementObject in managementObjectCollection)
            {
                string SystemName = await Task.Run(() => managementObject.Properties["SystemName"].Value.ToString().Trim());
                return SystemName.Trim();
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

        internal async static Task<string> EncryptAsync(string plainText, string passPhrase)
        {
            var saltStringBytes = await Task.Run(() => Generate256BitsOfRandomEntropy());
            var ivStringBytes = await Task.Run(() => Generate256BitsOfRandomEntropy());
            var plainTextBytes = await Task.Run(() => Encoding.UTF8.GetBytes(plainText));
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = await Task.Run(() => password.GetBytes(Keysize / 8));
                using (var symmetricKey = await Task.Run(() => new RijndaelManaged()))
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = await Task.Run(() => symmetricKey.CreateEncryptor(keyBytes, ivStringBytes)))
                    {
                        using (var memoryStream = await Task.Run(() => new MemoryStream()))
                        {
                            using (var cryptoStream = await Task.Run(() => new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)))
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

        internal async static Task<string> DecryptAsync(string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = await Task.Run(() => Convert.FromBase64String(cipherText));
            var saltStringBytes = await Task.Run(() => cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray());
            var ivStringBytes = await Task.Run(() => cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray());
            var cipherTextBytes = await Task.Run(() => cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray());

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = await Task.Run(() => password.GetBytes(Keysize / 8));
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 128;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = await Task.Run(() => symmetricKey.CreateDecryptor(keyBytes, ivStringBytes)))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            var plainTextBytes = new byte[cipherTextBytes.Length];
                            var decryptedByteCount = await Task.Run(() => cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length));
                            memoryStream.Close();
                            cryptoStream.Close();
                            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
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
