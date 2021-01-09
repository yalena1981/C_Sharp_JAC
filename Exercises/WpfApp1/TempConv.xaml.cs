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
    /// Interaction logic for TempConv.xaml
    /// </summary>
    public partial class TempConv : Window
    {
        public TempConv()
        {
            InitializeComponent();
        }

        private void rbtn_Checked(object sender, RoutedEventArgs e)
        {
            TempConvert();
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TempConvert();
        }

        private void TempConvert() 
        {
            double temp;
            if(!double.TryParse(inputTextBox.Text, out temp))
            {
                return;
            }

            if(rbtnInputCelcius.IsChecked == true)
            {
                if(rbtnOutputCelcius.IsChecked == true)
                {
                    result.Content = string.Format("{0:0.0} C", temp);

                }
                else if(rbtnOutputFarenheit.IsChecked == true)
                {
                    result.Content = string.Format("{0:0.0} F", (temp * 9 / 5) + 32);
                }

                else if (rbtnOutputKelvin.IsChecked == true)
                {
                    result.Content = string.Format("{0:0.0} K", (temp +273.15));

                }

            }
            if (rbtnInputFarenheit.IsChecked == true)
            {

            }
            if (rbtnInputKelvin.IsChecked == true)
            {

            }
        }
    }
}
