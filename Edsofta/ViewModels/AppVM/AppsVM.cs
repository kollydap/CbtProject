using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edsofta.Models.AppModels;
using Edsofta.Commands;

namespace Edsofta.ViewModels.AppVM
{
    public class AppsVM : INotifyPropertyChanged
    {
        #region iNotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    
        public AppsVM()
        {
            if (AppService.GetAppStatus())
            {
                appStatus = "Activated";
            }
            else
            {
                appStatus = "Not Acivated Yet";
            }

            activation = new ActivationCommand(ActivateTheApp);
        }

        private string appStatus;

        public string AppStatus
        {
            get { return appStatus; }
            set { appStatus = value; OnPropertyChanged("AppStatus"); }
        }

        private string activationCode;

        public string ActivationCode
        {
            get { return activationCode; }
            set { activationCode = value; }
        }

        private ActivationCommand activation;
        public ActivationCommand Activation
        {
            get { return activation; }
        }

     

        public void ActivateTheApp()
        {
            AppService.ActivateApp(ActivationCode);
        }
        

    }
}
