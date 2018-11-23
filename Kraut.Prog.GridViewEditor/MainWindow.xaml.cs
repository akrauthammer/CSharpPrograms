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

namespace Kraut.Prog.GridViewEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TabViewModel vmd;

        public MainWindow()
        {
            InitializeComponent();
            menu_view_explore.IsChecked = !treeViewExplorer.IsVisible;
            vmd = new TabViewModel();
            tabControl.ItemsSource = vmd.Tabs;
            vmd.Populate();


        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //vmd.Tabs.RemoveAt(tabControl.SelectedIndex);
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuViewExplorer_click(object sender, RoutedEventArgs e)
        {

            if (Column1.Width.Value > 0)
            {
                menu_view_explore.IsChecked = false;
                Column1.Width = new GridLength(0);
                ColumnSpacer.Width = new GridLength(0);
            }
            else
            {
                menu_view_explore.IsChecked = true;
                Column1.Width = new GridLength(100);
                ColumnSpacer.Width = new GridLength(2);

            }

        }
        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
