using System.Windows;
using Edsofta.Views;
namespace Edsofta
{
    /// <summary>
    /// Interaction logic for EdsoftaDesktop.xaml
    /// </summary>
    public partial class EdsoftaDesktop : Window
    {
        public EdsoftaDesktop()
        {

            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EdsoftaDesktop3 edsoftaDesktop3 = new EdsoftaDesktop3();
            edsoftaDesktop3.Show();
            Close();


        }
        private void OpenMaterial(object sender, RoutedEventArgs e)
        {
            SelectStudyMaterialByTopic studyMat = new SelectStudyMaterialByTopic();
            studyMat.Show();
            Close();

        }

        private void OpenNotes(object sender, RoutedEventArgs e)
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
