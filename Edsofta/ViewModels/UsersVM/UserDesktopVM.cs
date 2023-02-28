using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Edsofta.Models.UserModels;
using Edsofta.Models;

namespace Edsofta.ViewModels.UsersVM
{
     public class UserDesktopVM : INotifyPropertyChanged
    {
        #region iNotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        UsersModelService usersModelService;
        public UserDesktopVM()
        {
            usersModelService = new UsersModelService();
            CurrentUser =  usersModelService.LoggedInUser();

        }
        private UserModel currentUser;
        public UserModel CurrentUser
        {
            // get => currentUser;
            get { return currentUser; }
            set { currentUser = value; OnPropertyChanged("CurrentUser"); }
        }

    }
}
