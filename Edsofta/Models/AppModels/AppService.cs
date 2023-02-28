using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Edsofta.Models.AppModels
{
    public abstract class AppService
    {
        static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static  string appStatus = File.ReadAllText(APPDATA_PATH + @"\Edsofta\AppStatus.json");

        private static string SaveToJsonFile(List<AppModels> AppList, string jsonFileName)
        {
            string jsonString = JsonConvert.SerializeObject(AppList, Formatting.Indented);
            File.WriteAllText(jsonFileName, jsonString);
            return jsonString;
        }
        public static bool GetAppStatus()
        {
            

            List<AppModels> AppList = JsonConvert.DeserializeObject<List<AppModels>>(appStatus);
          

            return AppList[0].IsActivated;
        }
        public static void ActivateApp(string activationPin)
        {
            if(activationPin == "Edsofta2022")
            {
                List<AppModels> AppList = JsonConvert.DeserializeObject<List<AppModels>>(appStatus);
                AppList[0].IsActivated = true;
                SaveToJsonFile(AppList, appStatus);
            }
        }
    }
}
