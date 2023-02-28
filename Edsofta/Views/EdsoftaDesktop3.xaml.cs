using System.Windows;
using System.Windows.Input;
using Edsofta.Views;
using Edsofta.ViewModels;
using Edsofta.Models;

namespace Edsofta
{
    /// <summary>
    /// Interaction logic for EdsoftaDesktop3.xaml
    /// </summary>
    public partial class EdsoftaDesktop3 : Window
    {
        public EdsoftaDesktop3()
        {
            InitializeComponent();


        }

       
     

        private void Take_Test(object sender, RoutedEventArgs e)
        {

            //if (Test_Year.SelectedItem == null || Test_QuestionNo.SelectedItem == null)
            //{
            //    MessageBox.Show("Choose An Exam Year and number of Questions");
            //}
            //else
            //{
            //    EdsoftaDesktop9 edsoftaSignUp = new EdsoftaDesktop9();
            //    this.Content = edsoftaSignUp;

            //}

            EdsoftaDesktop9 edsoftaSignUp = new EdsoftaDesktop9();
            this.Content = edsoftaSignUp;

            QuestionsViewModel questionsViewModel = new QuestionsViewModel();
             



        }

        private void Set_Yoruba_Test_Prop(object sender, RoutedEventArgs e)
        {
            YorubadropPanel.Visibility = Visibility.Visible;
            subjectkeyy.sk = "YORUBA";
            EnglishdropPanel.Visibility = Visibility.Collapsed;

        }
        private void Set_English_Test_Prop(object sender, RoutedEventArgs e)
        {
            EnglishdropPanel.Visibility = Visibility.Visible;
            subjectkeyy.sk = "ENGLISH";
            YorubadropPanel.Visibility = Visibility.Collapsed;
        }

        private void OpenHomeWindow(object sender, RoutedEventArgs e)
        {
            EdsoftaDesktop edsoftaDesktop = new EdsoftaDesktop();
            edsoftaDesktop.Show();
            Close();
        }

        private void OpenNotesWindow(object sender, RoutedEventArgs e)
        {
            NotesPage notesPage = new NotesPage();
            notesPage.Show();
            Close();
        }

        private void OpenSettingsWindow(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
            Close();
        }
    }
}
