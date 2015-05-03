using Mvvm;

namespace XamlBrewer.MouseCommandBar.Services
{
    class Device: BindableBase
    {
        private readonly static Device _instance;
        private InputMode _inputMode;

        static Device()
        {
            _instance = new Device();

            // No touch -> Desktop
            if (new Windows.Devices.Input.TouchCapabilities().TouchPresent == 0)
            {
                _instance._inputMode = InputMode.Desktop;
            }

            // No mouse -> Touch Optimized
            if (new Windows.Devices.Input.MouseCapabilities().MousePresent == 0)
            {
                _instance._inputMode = InputMode.TouchOptimized;
            }

            // Otherwise -> Touch Enabled
            _instance._inputMode = InputMode.TouchEnabled;
        }

        public static Device Instance
        { get { return _instance; } }

        public InputMode InputMode
        {
            get { return this._inputMode; }
            set { this.SetProperty(ref this._inputMode, value); }
        }
    }
}
