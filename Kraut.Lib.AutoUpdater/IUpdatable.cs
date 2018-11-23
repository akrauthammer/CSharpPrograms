using System;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace Kraut.Lib.AutoUpdater
{
    public interface IUpdatable
    {
        string ApplicationName { get; }
        string ApplicationId { get; }
        Assembly ApplicationAssembly { get; }
        ImageSource ApplicationIcon { get; }
        Uri UpdateXmlLocation { get; }
        Window Context { get; }
    }
}
