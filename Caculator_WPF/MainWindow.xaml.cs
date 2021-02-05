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

namespace Caculator_WPF
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

        private void btnMoNgoac_Click(object sender, RoutedEventArgs e)
        {
            Button btnTarget = sender as Button;
            pnScreen.Text += btnTarget.Content.ToString();
        }

        private void btnAc_Click(object sender, RoutedEventArgs e)
        {
            if(pnScreen.Text !="")
            {
                pnScreen.Text = pnScreen.Text.Remove(pnScreen.Text.Length - 1);
            }    
        }
    }
}
