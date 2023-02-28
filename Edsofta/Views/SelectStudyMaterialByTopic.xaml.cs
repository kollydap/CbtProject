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

namespace Edsofta.Views
{
    /// <summary>
    /// Interaction logic for SelectStudyMaterialByTopic.xaml
    /// </summary>
    public partial class SelectStudyMaterialByTopic : Window
    {
        public SelectStudyMaterialByTopic()
        {
            InitializeComponent();
        }

        private void SelectBiology(object sender, RoutedEventArgs e)
        {
            SetSubject.SubjectKey = "Ecology";
            StudyMaterial studyMaterial = new StudyMaterial();
            studyMaterial.Show();
            Close();



        }
        private void SelectGovernment(object sender, RoutedEventArgs e)
        {
            SetSubject.SubjectKey = "Government";
            StudyMaterial studyMaterial = new StudyMaterial();
            studyMaterial.Show();
            Close();



        }
    }
}
