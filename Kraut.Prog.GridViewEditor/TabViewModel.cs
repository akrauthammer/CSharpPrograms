using System.Collections.ObjectModel;

namespace Kraut.Prog.GridViewEditor
{
    class TabViewModel
    {
        // These Are the tabs that will be bound to the TabControl 
        public ObservableCollection<GridTab> Tabs { get; set; }

        public TabViewModel()
        {
            Tabs = new ObservableCollection<GridTab>();
        }

        public void Populate()
        {
            // Add A tab to TabControl With a specific header and Content(UserControl)
            Tabs.Add(new GridTab { Header = "d 1" });
            // Add A tab to TabControl With a specific header and Content(UserControl)
            Tabs.Add(new GridTab { Header = "UserControl 2" });

        }
    }
}
