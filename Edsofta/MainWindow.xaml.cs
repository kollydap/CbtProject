using System.Windows;
namespace Edsofta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton(object sender, RoutedEventArgs e)
        {
            EdsoftaSignUp edsoftaSignUp = new EdsoftaSignUp();
            Content = edsoftaSignUp;
        }
    }
}
