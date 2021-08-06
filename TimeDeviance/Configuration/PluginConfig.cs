using System.Runtime.CompilerServices;
using IPA.Config.Stores;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace TimeDeviance.Configuration
{
    public class PluginConfig
    {
        public virtual bool Enabled { get; set; }
    }
}
