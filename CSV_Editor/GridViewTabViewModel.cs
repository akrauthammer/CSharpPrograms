using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Editor
{
    class GridViewTabViewModel
    {
        // These Are the tabs that will be bound to the TabControl 
        public ObservableCollection<GridViewTab> Tabs { get; set; }

        public GridViewTabViewModel()
        {
            Tabs = new ObservableCollection<GridViewTab>();
        }

        public void Populate()
        {
            // Add A tab to TabControl With a specific header and Content(UserControl)
            Tabs.Add(new GridViewTab { Header = "d 1"});
            // Add A tab to TabControl With a specific header and Content(UserControl)
            Tabs.Add(new GridViewTab { Header = "UserControl 2"});
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
            Tabs.Add(new GridViewTab { Header = "UserControl 2" });
        }
    }
}
