using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Newtonsoft.Json;
using System.IO;
using Edsofta.Models;

namespace Edsofta.Views
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public SplashScreen()
        {
            InitializeComponent();
            dT.Tick += new EventHandler(dt_Tick);
            dT.Interval = new TimeSpan(0, 0, 3);
            dT.Start();
        }
        private void dt_Tick(object sender, EventArgs e)
        {
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userJson = File.ReadAllText(APPDATA_PATH + @"\Edsofta\Users.json");
            List<UserModel> usersList = LoadUsersFromJsonString(userJson);
            if(usersList.Count > 0)
            {
                
                EdsoftaDesktop edsoftaDesktop = new EdsoftaDesktop();
                edsoftaDesktop.Show();
                dT.Stop();
                this.Close();
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                dT.Stop();
                this.Close();
            }
           
        }

        private static List<UserModel> LoadUsersFromJsonString(string jsonString)
        {

            List<UserModel> result = JsonConvert.DeserializeObject<List<UserModel>>(jsonString);
            return result;
        }
    }
}
