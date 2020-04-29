using System.Windows;

namespace Indexer.WPF
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

        private void AppShutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            cntCtrl.Content = new ItemControl();
        }
    }
}
