﻿using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POSWarehouse.Classes
{
    class Security
    {
        private static readonly string ApplicationName = "Super Market System",
            // TODO: change app name
            //DatabaseNameOld = $@"[{System.Windows.Forms.Application.StartupPath}\Data\POSWarehouseDB.mdf]",
            //DatabaseNameNew = $@"[C:\USERS\ESLAM\DOCUMENTS\VISUAL STUDIO 2019\PROJECTS\SUPERMARKET\SUPERMARKET\BIN\DEBUG\DATA\POSWAREHOUSEDB.MDF]",
            DatabaseNameNew = "POSWarehouseDatabase",
            DriveLetter = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
            DirectoryLocation = $@"{DriveLetter}Users\{Environment.UserName}\AppData\Local\{ApplicationName}",
            SerialKeyFileName = @"\serial",
            SerialDateTimeKeyFileName = @"\datetime",
            FileExtention = ".enc",
            SerialKeyFileLocation = DirectoryLocation + SerialKeyFileName + FileExtention,
            SerialKeyDateTimeFileLocation = DirectoryLocation + SerialDateTimeKeyFileName + FileExtention;

        public static string CPUID = "", MOBOID = "", CPUName = "", CPUCores = "", CPUSpeed = "", SystemName = "";

        public static bool OpenFormMain = false;

        private static int TrialDays;
        private static double TrialDaysLeft;

        public static double GetTrialDaysLeft()
        {
            return TrialDaysLeft;
        }

        public static int GetTrialDays()
        {
            return TrialDays;
        }

        //public static string GetDBNameOld()
        //{
        //    return DatabaseNameOld;
        //}

        public static string GetDBName()
        {
            return DatabaseNameNew;
        }

        public static string GetDriveLetter()
        {
            return DriveLetter;
        }

        public static string GetSerialKeyDateTimeFileLocation()
        {
            return SerialKeyDateTimeFileLocation;
        }

        public static string GetSerialKeyFileLocation()
        {
            return SerialKeyFileLocation;
        }

        public static string GetDirecotryLocation()
        {
            return DirectoryLocation;
        }

        public async static Task<double> CalculateTrialDaysLeft()
        {
            DateTime LicenseDateTime = DateTime.Parse(await DecryptAsync(File.ReadAllText(SerialKeyDateTimeFileLocation), CPUID + MOBOID));

            double OnlineAndLicenseDiff = (await Methods.GetTimeOnline() - LicenseDateTime).TotalDays;

            double DaysLeft = GetTrialDays() - OnlineAndLicenseDiff;

            TrialDaysLeft = DaysLeft;

            return DaysLeft;
        }

        public async static Task SetupTrialDays()
        {
            if (await SerialKeyFileExists())
            {
                string LisenceKey = await DecryptAsync(File.ReadAllText(SerialKeyFileLocation), CPUID + MOBOID);

                StringBuilder sb_lisenceKey = new StringBuilder(LisenceKey);

                if (sb_lisenceKey[3] == 't' || sb_lisenceKey[3] == 'T')
                    TrialDays = int.Parse(sb_lisenceKey[5].ToString() + sb_lisenceKey[6].ToString());

                else if (sb_lisenceKey[3] == 'f' || sb_lisenceKey[3] == 'F')
                    TrialDays = -1;

                else
                    TrialDays = 0;
            }
            else
            {
                TrialDays = -2;
            }
        }

        internal async static Task MoveSerialKeyFile(string SerialFileLocation)
        {
            string FileSerialName = "\\serial.enc";
            string FileDateTimeName = "\\datetime.enc";

            if (!Directory.Exists(DirectoryLocation))
                Directory.CreateDirectory(DirectoryLocation);

            if (File.Exists(SerialFileLocation))
            {
                if (File.Exists(DirectoryLocation + FileSerialName))
                    File.Delete(DirectoryLocation + FileSerialName);

                File.Move(SerialFileLocation, DirectoryLocation + FileSerialName);

                if (File.Exists(DirectoryLocation + FileDateTimeName))
                    File.Delete(DirectoryLocation + FileDateTimeName);

                using (FileStream fs = File.Create(DirectoryLocation + FileDateTimeName))
                {
                    string dateTime = DateTime.Now.ToString();
                    Byte[] title = new UTF8Encoding(true).GetBytes(await EncryptAsync(dateTime, await GetCpuID() + await GetMotherBoardID()));
                    fs.Write(title, 0, title.Length);
                    fs.Close();
                }


                //File.Move(FileDateTimeSource, DirectoryLocation + FileDateTimeSource);
            }
        }

        public async static Task<string> CheckLicenseKeyOnAppAsync()
        {
            await SerialKeyFileExists();

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
                MOBOID = await Task.Run(() => GetMotherBoardID());
                CPUName = await Task.Run(() => GetCpuInfo("Name"));
                CPUCores = await Task.Run(() => GetCpuInfo("NumberOfCores"));
                CPUSpeed = await Task.Run(() => GetCpuInfo("CurrentClockSpeed"));
                SystemName = await Task.Run(() => GetCpuInfo("SystemName"));
            }
        }

        public async static Task<string> CheckLicenseKeyValidity(string LicenseKey)
        {
            if (await SerialKeyFileExists())
            {
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
            else
            {
                Logger.Log($"serial file isnt found in the location: <{DirectoryLocation}>",
                            System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
                return "404";
            }
        }

        internal async static Task<bool> SerialKeyFileExists()
        {
            bool state = true;

            if (!Directory.Exists(DirectoryLocation))
            {
                await Task.Run(() => Directory.CreateDirectory(DirectoryLocation));
                Logger.Log("created the directory for the serial", System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
            }

            if (!File.Exists(DirectoryLocation + SerialKeyFileName + FileExtention))
            {
                Logger.Log("serial key file doesnt exis", System.Reflection.MethodInfo.GetCurrentMethod().Name, "LoginMethods", Logger.CRITICAL);
                state = false;
                //File.Create(DirectoryLocation + SerialKeyFileName + FileExtention).Close();
            }

            return state;
        }

        #region Computer information

        private async static Task<string> GetMotherBoardID()
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
