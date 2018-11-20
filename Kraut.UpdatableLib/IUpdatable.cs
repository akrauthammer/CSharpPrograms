using System;
using System.Reflection;


namespace Kraut.UpdatableLib
{
    public interface IUpdatable
    {
        string ApplicationName { get; }
        string ApplicationId { get; }
        Assembly ApplicationAssembly { get; }
        //Icon ApplicationIcon { get; }
        Uri UpdateXmlLocation { get; }
        //Form Context { get; }
    }
}
