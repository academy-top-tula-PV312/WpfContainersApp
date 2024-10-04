using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfContainersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //for(int i = 0; i < 12; i++)
            //{
            //    Button btn = new Button();
            //    btn.Content = (i + 1).ToString();
            //    btn.FontSize = 24;
            //    ugrid.Children.Add(btn);
            //}
        }
    }
}