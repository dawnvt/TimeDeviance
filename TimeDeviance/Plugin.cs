using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;
using IPA.Config.Stores;
using TimeDeviance.Configuration;
using TimeDeviance.Installers;
using Config = IPA.Config.Config;

namespace TimeDeviance
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        private PluginConfig _config;

        [Init]
        public void Init(Zenjector zenjector, IPALogger logger, Config config)
        {
            _config = config.Generated<PluginConfig>();
            
            zenjector.OnMenu<MenuInstaller>().WithParameters(logger, _config).ShortCircuitForMultiplayer();
            zenjector.OnGame<GameInstaller>().ShortCircuitForMultiplayer();
        }

        [OnEnable, OnDisable]
        public void OnChange()
        {
        }
    }
}
