using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Path = System.IO.Path;

namespace Edsofta.UtilityClasses
{
    internal class AppValidation
    {
        /// <summary>
        /// The product identifier
        /// </summary>
        //private static string ProductID = string.Empty;



        //public static async Task<bool> activateProduct(string activationKey)
        //{
        //    var isActivated = false;
        //    var activationKeyText = string.Empty;
        //    var appDataPath = Path.Combine(App.AppDataPath, App.ResourcePaths["UserData"], App.Files["AppData"]);

        //    //bug:v001-fix003: use a txt file to hold activation key
        //    var altAppDataPath = Path.Combine(App.AppDataPath, App.ResourcePaths["UserData"], App.Files["AltAppData"]);

        //    try
        //    {
        //        if (!File.Exists(appDataPath)) return false;

        //        var jsonData = await FileParser.readFileAsync(appDataPath);
        //        var appData = JsonConvert.DeserializeObject<AppData>(jsonData);

        //        if (string.IsNullOrWhiteSpace(activationKey))
        //        {
        //            activationKey = appData.ActivationKey;
        //        }

        //        if (matchActivationID(activationKey, appData.ProductKey))
        //        {
        //            isActivated = true;
        //            appData.ActivationKey = activationKey;
        //        }


        //        FileParser.SaveToJson(appData, appDataPath);

        //        return isActivated;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}


        //public static string getProductKey()
        //{
        //    var productKey = string.Empty;
        //    var appDataPath = Path.Combine(App.AppDataPath, App.ResourcePaths["UserData"], App.Files["AppData"]);

        //    try
        //    {

        //        if (File.Exists(appDataPath))
        //        {
        //            var jsonData = FileParser.readFile(appDataPath);
        //            if (string.IsNullOrWhiteSpace(jsonData))
        //            {
        //                File.Delete(appDataPath);
        //                var result = createAppdata();
        //                if (!result) return DeviceInformationClass.GenerateProductKey();

        //            }
        //            var appData = JsonConvert.DeserializeObject<AppData>(jsonData);

        //            if (DeviceInformationClass.GenerateProductKey() == appData.ProductKey)
        //            {
        //                productKey = appData.ProductKey;
        //            }
        //            else
        //            {
        //                Application.Current.Shutdown();
        //            }
        //        }
        //        else
        //        {
        //            createAppdata();
        //            var jsonData = FileParser.readFile(appDataPath);
        //            var appData = JsonConvert.DeserializeObject<AppData>(jsonData);
        //            productKey = appData.ProductKey;
        //        }

        //        return productKey;
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //}


        //public static async Task<string> getProductKeyAsync()
        //{
        //    var productKey = string.Empty;
        //    var appDataPath = Path.Combine(App.AppDataPath, App.ResourcePaths["UserData"], App.Files["AppData"]);

        //    try
        //    {

        //        if (File.Exists(appDataPath))
        //        {
        //            var jsonData = await FileParser.readFileAsync(appDataPath);
        //            if (string.IsNullOrWhiteSpace(jsonData))
        //            {
        //                File.Delete(appDataPath);
        //                var result = createAppdata();
        //                if (!result) return DeviceInformationClass.GenerateProductKey();

        //            }
        //            var appData = JsonConvert.DeserializeObject<AppData>(jsonData);

        //            if (DeviceInformationClass.GenerateProductKey() == appData.ProductKey)
        //            {
        //                productKey = appData.ProductKey;
        //            }
        //            else
        //            {
        //                Application.Current.Shutdown();
        //            }
        //        }
        //        else
        //        {
        //            createAppdata();
        //            var jsonData = await FileParser.readFileAsync(appDataPath);
        //            var appData = JsonConvert.DeserializeObject<AppData>(jsonData);
        //            productKey = appData.ProductKey;
        //        }

        //        return productKey;
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //}


        ///// <summary>
        ///// Matches the activation identifier.
        ///// </summary>
        ///// <param name="activationKey">The activation key.</param>
        ///// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        //private static bool matchActivationID(string activationKey, string productKey)
        //{
        //    var isMatch = false;
        //    if (activationKey.Length != 12) return isMatch;
        //    var firstCharVal = char.IsDigit(activationKey[0]) ? int.Parse(activationKey[0].ToString()) : 6;
        //    var check = firstCharVal == 5 || firstCharVal == 7;
        //    var keyLength = check ? firstCharVal : 6;
        //    var privateKey = activationKey.Substring(activationKey.Length - keyLength, keyLength);
        //    var decodedKey = BaseOperation.fromDeci(32, BaseOperation.toDeci(DeviceInformationClass.restoreInString(privateKey), 30));
        //    var match = BaseOperation.fromDeci(32, BaseOperation.toDeci(DeviceInformationClass.restoreInString(productKey), 32)).Substring(3, 6);
        //    if (BaseOperation.toDeci(decodedKey, 32) == BaseOperation.toDeci(match, 32))
        //    {
        //        isMatch = true;
        //    }

        //    return isMatch;
        //}


        //private static bool createAppdata()
        //{
        //    var appDataPath = Path.Combine(App.AppDataPath, App.ResourcePaths["UserData"], App.Files["AppData"]);
        //    try
        //    {
        //        var productKey = DeviceInformationClass.GenerateProductKey();
        //        var appData = new AppData
        //        {
        //            ProductKey = productKey,
        //            ActivationKey = string.Empty,
        //            Notifications = true,
        //            Theme = ThemeHelper.InitializeAppTheme()
        //        };

        //        return FileParser.SaveToJson(appData, appDataPath);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

    }
}
