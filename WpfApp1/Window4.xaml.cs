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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            var Window7 = new Window7(); //create your new form.
            Window7.Show(); //show the new form.
            this.Close();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            var Window2 = new Window2(); //create your new form.
            Window2.Show(); //show the new form.
            this.Close();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            var Window3 = new Window3(); //create your new form.
            Window3.Show(); //show the new form.
            this.Close();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            var Window4 = new Window4(); //create your new form.
            Window4.Show(); //show the new form.
            this.Close();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            var Window5 = new Window5(); //create your new form.
            Window5.Show(); //show the new form.
            this.Close();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            var Window5 = new Window5(); //create your new form.
            Window5.Show(); //show the new form.
            this.Close();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            var Window6 = new Window6(); //create your new form.
            Window6.Show(); //show the new form.
            this.Close();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1(); //create your new form.
            Window1.Show(); //show the new form.
            this.Close();
        }
    }
}
