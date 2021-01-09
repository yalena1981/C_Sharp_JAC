using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> selectedOnes = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            const string dataFile = @"..\..\flavors.txt";
            if(File.Exists(dataFile))
            {
                List<string> flavorslist = new List<string>();
                foreach(string line in File.ReadAllLines(dataFile))
                {
                    flavorslist.Add(line);
                }
                lvIceCreamFlavors.ItemsSource = flavorslist;
            }
        }

        private void BtnDeleteScoop_Clicked(object sender, RoutedEventArgs e)
        {
            if(lvSelectedFlavors.Items.Count == 0)
            {
                return;
            }
            if(lvSelectedFlavors.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a scoop");
                return;
            }
            var selectedForDelete = lvSelectedFlavors.SelectedItems;
            foreach(string item in selectedForDelete)
            {
                selectedOnes.Remove(item);
            }
            lvSelectedFlavors.ItemsSource = null;
            lvSelectedFlavors.ItemsSource = selectedOnes;

        }

        private void btnAddFlavors_Click(object sender, RoutedEventArgs e)
        {
            if(lvIceCreamFlavors.SelectedIndex == -1)
            {
                MessageBox.Show("You need to choose a flavor");
                return;
            }
            var selectedList = lvSelectedFlavors.SelectedItems;
            
            foreach(string item in selectedList)
            {
                selectedOnes.Add(item);
            }
            lvSelectedFlavors.ItemsSource = null;
            lvSelectedFlavors.ItemsSource = selectedOnes;
            lvSelectedFlavors.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if(lvSelectedFlavors.Items.Count == 0)
            {
                return;
            }
            MessageBoxResult result = MessageBox.Show("Are you sure to delete the list?", "Clear all", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(result == MessageBoxResult.Yes)
            {
                lvSelectedFlavors.ItemsSource = null;
            }
            selectedOnes.Clear();
        }
    }
}
