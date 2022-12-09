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

namespace obsah_a_obvod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a, b, c, d, e;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Povrch kvádru:" + vypocet().ToString() + "cm2"
                + "       Obsah kvadru:" + vypocetp().ToString()+"cm3");
        }

        public MainWindow()
        {
            
            InitializeComponent();
            
        }
        public int vypocet()
        {

            a = Convert.ToInt32(A.Text);
            b = Convert.ToInt32(A.Text);
            c = Convert.ToInt32(C.Text);
            d = 2*((a*b)+(a*c)+(b*c));
            return d;
        }
        public int vypocetp()
        {
            e = a * b * c;
            return e;

        }



        

       
    }
}
