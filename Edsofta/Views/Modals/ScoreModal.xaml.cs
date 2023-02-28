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
using Edsofta.ViewModels;

namespace Edsofta.Views.Modals
{
    /// <summary>
    /// Interaction logic for ScoreModal.xaml
    /// </summary>
  
    public partial class ScoreModal : Window
    {
        public ScoreModal()
        {

              
            InitializeComponent();
            
        }

        private void TryAgain(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
