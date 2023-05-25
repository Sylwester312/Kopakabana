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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kopakabana
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

        private void ButtonSedzia_Click(object sender, RoutedEventArgs e)
        {
            OpcjeSedziow opcjeSedziow = new OpcjeSedziow();
            opcjeSedziow.ShowDialog();
        }

        private void ButtonDruzyna_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRozrywka_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
