using System.Windows.Controls;

namespace Kraut.Prog.GridViewEditor
{
    class GridTab
    {
        // This will be the text in the tab control
        public string Header { get; set; }
        // This will be the content of the tab control It is a UserControl whits you need to create manualy
        public UserControl Content { get; set; }
    }
}
