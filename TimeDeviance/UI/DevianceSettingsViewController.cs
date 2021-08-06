using System;
using System.ComponentModel;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.GameplaySetup;
using TimeDeviance.Configuration;
using Zenject;

namespace TimeDeviance.UI
{
    public class DevianceSettingsViewController : IInitializable, IDisposable, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PluginConfig _config;
        public DevianceSettingsViewController(PluginConfig config)
        {
            _config = config;
        }

        [UIValue("enabled")]
        private bool DevianceEnabled
        {
            get => _config.Enabled;
            set
            {
                _config.Enabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DevianceEnabled)));
            } 
        }

        public void Initialize()
        {
            GameplaySetup.instance.AddTab("TimeDeviance", "TimeDeviance.UI.BSML.DevianceSettings.bsml", this);
        }

        public void Dispose()
        {
            GameplaySetup.instance.RemoveTab("TimeDeviance");
        }
    }
}