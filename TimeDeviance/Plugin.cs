using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;
using IPA.Config.Stores;
using TimeDeviance.Installers;
using Config = IPA.Config.Config;

namespace TimeDeviance
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        [Init]
        public void Init(IPALogger logger, Zenjector zenjector, Config config)
        {
            zenjector.OnGame<GameInstaller>().ShortCircuitForMultiplayer();
        }

        [OnEnable, OnDisable]
        public void OnChange()
        {
        }
    }
}
