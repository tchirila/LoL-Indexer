using System.Windows.Controls;

namespace Indexer.WPF.Pages
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Report()
        {
            InitializeComponent();
        }

        public Report(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
