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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private NameUserControl name;
        private PositionUserControl position;
        public MainWindow()
        {
            InitializeComponent();
            name = new NameUserControl();
            position = new PositionUserControl();

        }

        private void Button_Click(Object sender, RoutedEventArgs e)
        {
            //Name
            uccContainer.Content = name;
        }

        private void Button_Click_1(Object sender, RoutedEventArgs e)
        {
            //Position
            uccContainer.Content = position;
        }
        
    }
}
