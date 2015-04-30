namespace XamlBrewer.MouseCommandBar.Services
{
    public class Device
    {
        private static InputMode _inputMode;

        static Device()
        {
            // No touch -> Desktop
            if (new Windows.Devices.Input.TouchCapabilities().TouchPresent == 0)
            {
                _inputMode = InputMode.Desktop;
            }

            // No mouse -> Touch Optimized
            if (new Windows.Devices.Input.MouseCapabilities().MousePresent == 0)
            {
                _inputMode = InputMode.TouchOptimized;
            }

            // Otherwise -> Touch Enabled
            _inputMode = InputMode.TouchEnabled;
        }

        public static InputMode InputMode
        {
            get { return _inputMode; }
            set { _inputMode = value; }
        }
    }
}
