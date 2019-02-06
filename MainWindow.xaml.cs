/* Josh Degazio
 * Feb 6, 2019
 * Hello World my "first" program
 */
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

namespace _182685HelloWorld
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = input_name.Text;
            MessageBox.Show("Hey " + name + ", thanks for checking out my program.");
            MessageBox.Show("Sike, you just got ebola.");
            message.Content = "Hello, " + name + ", and welcome.";
        }
    }
}
