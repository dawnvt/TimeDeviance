using IPA.Logging;
using TimeDeviance.Configuration;
using TimeDeviance.UI;
using Zenject;

namespace TimeDeviance.Installers
{
    public class MenuInstaller : Installer
    {
        private readonly PluginConfig _config;
        private readonly Logger _logger;

        public MenuInstaller(Logger logger, PluginConfig config)
        {
            _config = config;
            _logger = logger;
        }
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<DevianceSettingsViewController>().AsSingle();
            Container.BindInstance(_config).AsSingle();
            Container.BindInstance(_logger).AsSingle();
        }
    }
}