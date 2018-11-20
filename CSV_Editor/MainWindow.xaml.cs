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

namespace CSV_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GridViewTabViewModel vmd;

        public MainWindow()
        {
            InitializeComponent();
            // Initialize viewModel
            vmd = new GridViewTabViewModel();
            // Bind the xaml TabControl to view model tabs
            tabControl.ItemsSource = vmd.Tabs;
            // Populate the view model tabs
            vmd.Populate();
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // This event will be thrown when on a close image clicked
            vmd.Tabs.RemoveAt(tabControl.SelectedIndex);
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
