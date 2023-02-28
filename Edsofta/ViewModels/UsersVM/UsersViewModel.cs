using System;
using Edsofta.Models;
using Edsofta.Commands;
using Edsofta.Models.UserModels;
using System.ComponentModel;



namespace Edsofta.ViewModels
{
    public class UsersViewModel : INotifyPropertyChanged
    {

        #region iNotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        UsersModelService UsersModelService;
        public UsersViewModel()
        {
            addNewUser =  new UserCommand(Save);
            loginUser = new UserCommand(checkUserAboutToLogin);
            CurrentUser = new UserModel();
            UsersModelService = new UsersModelService();
        }

        private UserModel currentUser ;
        public UserModel CurrentUser
        {
            // get => currentUser;
            get { return currentUser; }
            set { currentUser = value; OnPropertyChanged("CurrentUser"); }
        }


        private string message;
        public string Message
        {
            get =>  message; 
            set { message = value; OnPropertyChanged("Message"); }
        }

        private UserCommand addNewUser;
        public UserCommand AddNewUser
        {
            get { return addNewUser; }
        }

        private UserCommand loginUser;
        public UserCommand LoginUser
        {
            get { return loginUser; }
        }

        #region Authenttication Delegates
        public void Save()
        {
            try
            {
                bool IsSaved = UsersModelService.AddUser(CurrentUser);
                if (IsSaved)
                {
                    Message = "Successfully Created An Account";
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                 
                }
                else
                {
                    Message = "Could Not Creaate User! ";
                }
                //Message = IsSaved ? "Successfully Created An Account"   : "Saved Operation Failed";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }   
        }
        public void checkUserAboutToLogin()
        {
            try
            {
                bool IsUserAuthenticated = UsersModelService.LoginUser(CurrentUser);
                Message = IsUserAuthenticated ? $"Welcome Back {CurrentUser.UserName}" : "Check UserName or Password";

                if (IsUserAuthenticated)
                {
                    EdsoftaDesktop edsoftaDesktop = new EdsoftaDesktop();
                    edsoftaDesktop.Show();

                }

            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            }

            #endregion

            //tHE cOMMAND hELPS TO bIND tHe cuRRent User to the List

            // private static List<QuestionsModel> QuestionList = JsonConvert.DeserializeObject<List<QuestionsModel>>(questionJson);
            //on Command Click let the person create A new instance of user and add to the User model
        }
}
