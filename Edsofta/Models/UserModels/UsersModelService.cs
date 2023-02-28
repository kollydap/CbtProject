using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Edsofta.Models.UserModels
{
    public class UsersModelService
    {
        
        public  List<UserModel> UserList;
        public UsersModelService()
        {
            UserList = new List<UserModel>();
        }

        private static string SaveToJsonFile(List<UserModel> userList, string jsonFileName)
        {
            string jsonString = JsonConvert.SerializeObject(userList, Formatting.Indented);
            File.WriteAllText(jsonFileName, jsonString);
            return jsonString;
        }


        #region Authentication Methods

        public bool AddUser(UserModel user)
        {
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userJson = File.ReadAllText(APPDATA_PATH + @"\Edsofta\Users.json");
            List<UserModel> usersList = LoadUsersFromJsonString(userJson);
          
            if (usersList.Contains(user) || usersList.Count == 2)
            {
                throw new ArgumentException("you cant");
                return false; 
            }
            else
            {
                if (user.Password != user.Password2 )
                    throw new ArgumentException("Passwords Must Match");
                else if (user.FirstName == null)
                {
                    throw new ArgumentException("Add A FirstName Please");
                }
                else if (user.SurName == null)
                {
                    throw new ArgumentException("Add A SurName Please");
                }
                else if (user.UserName == null)
                {
                    throw new ArgumentException("Add A Username Please");
                }
                else if (user.Email == null)
                {
                    throw new ArgumentException("Add A Email Please");
                }
                else if (user.PhoneNumber == null)
                {
                    throw new ArgumentException("Add A PhoneNmber Please");
                }
                else if (user.Password == null)
                {
                    throw new ArgumentException("Add A PassWord Please");
                }
                else if (user.Password2 == null)
                {
                    throw new ArgumentException("Add A secound Password Please");
                }

                UserList.Add(user);
                SaveToJsonFile(UserList, APPDATA_PATH + @"\Edsofta\Users.json");
                return true;
            }         
        }

        private static List<UserModel> LoadUsersFromJsonString(string jsonString)
        {
            
            List<UserModel> result = JsonConvert.DeserializeObject<List<UserModel>>(jsonString);
            return result;
        }
        

        public bool LoginUser(UserModel user)
        {
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userJson = File.ReadAllText(APPDATA_PATH+@"\Edsofta\Users.json");
            List<UserModel> usersList = LoadUsersFromJsonString(userJson);
           
            foreach (UserModel UserInUsersList in usersList)
            {
                //user == Users ? true : false;
                if(user.UserName == UserInUsersList.UserName && user.Password == UserInUsersList.Password )
                {
                    return true;
                } 
            }
            return false;
        }

        public UserModel LoggedInUser()
        {
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userJson = File.ReadAllText(APPDATA_PATH + @"\Edsofta\Users.json");
            List<UserModel> usersList = LoadUsersFromJsonString(userJson);
            return usersList[0];
        }
        #endregion

    }
}
