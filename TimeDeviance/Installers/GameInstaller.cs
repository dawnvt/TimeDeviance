using IPA.Logging;
using TimeDeviance.Configuration;
using TimeDeviance.Controllers;
using Zenject;

namespace TimeDeviance.Installers
{
    public class GameInstaller : Installer
    {
        private readonly Logger _logger;
        
        public GameInstaller(Logger logger)
        {
            _logger = logger;
        }
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameController>().AsSingle();
            Container.BindInstance(_logger).AsSingle();
        }
    }
}