using System;
using System.Windows;

namespace Edsofta.Views
{
    /// <summary>
    /// Interaction logic for StudyMaterial.xaml
    /// </summary>
    public partial class StudyMaterial : Window
    {
        public StudyMaterial()
        {
           
            InitializeComponent();
            string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            myBrowser.Navigate(new Uri(APPDATA_PATH +@"/Edsofta/"+ SetSubject.SubjectKey +".html"));
        }
       
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoBack)
            {
                myBrowser.GoBack();
            }
            else
            {
                MessageBox.Show("Cannot Go back");
            }
        }
        private void GoForward_Click(object sender, RoutedEventArgs e)
        {
            if (myBrowser.CanGoForward)
            {
                myBrowser.GoForward();
            }
            else
            {
                MessageBox.Show("Cannot Go Forward");
            }
        }
    }

    public abstract class SetSubject
    {
        public static string SubjectKey { get; set; }
    }

}

