using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Drawing;
using Kraut.Lib.AutoUpdater;

namespace Kraut.Prog.GridViewEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IUpdatable
    {
        private TabViewModel vmd;

        public string ApplicationName { get { return "AKs Editor"; } }
        public string ApplicationId { get { return "GridViewEditor"; } }
        public Assembly ApplicationAssembly { get { return Assembly.GetExecutingAssembly(); } }
        public ImageSource ApplicationIcon { get { return this.Icon; } }
        public Uri UpdateXmlLocation { get { return new Uri(""); } }
        public Window Context { get { return this; } }

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
            vmd.Tabs.RemoveAt(tabControl.SelectedIndex);
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
                Column1.Width = new GridLength(150);
                ColumnSpacer.Width = new GridLength(2);

            }

        }

    }
}
