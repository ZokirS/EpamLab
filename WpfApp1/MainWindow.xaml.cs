using System.Windows;
using standard;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class1 class1 = new Class1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = tbName.Text;
            var res = class1.GetCurrentTime(name);

            MessageBox.Show(res);
        }
    }
}
