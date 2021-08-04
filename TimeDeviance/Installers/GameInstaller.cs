using IPA.Logging;
using TimeDeviance.Configuration;
using TimeDeviance.Controllers;
using Zenject;

namespace TimeDeviance.Installers
{
    public class GameInstaller : Installer
    {
        private readonly PluginConfig _config;
        private readonly Logger _logger;
        
        public GameInstaller(PluginConfig config, Logger logger)
        {
            _config = config;
            _logger = logger;
        }
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameController>().AsSingle();
            Container.BindInstance(_config).AsSingle();
            Container.BindInstance(_logger).AsSingle();
        }
    }
}