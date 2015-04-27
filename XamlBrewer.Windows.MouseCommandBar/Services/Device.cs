namespace XamlBrewer.MouseCommandBar.Services
{
    public class Device
    {
        public static InputMode InputMode
        {
            get
            {
                // No touch -> Desktop
                if (new Windows.Devices.Input.TouchCapabilities().TouchPresent == 0)
                {
                    return InputMode.Desktop;
                }

                // No mouse -> Touch Optimized
                if (new Windows.Devices.Input.MouseCapabilities().MousePresent == 0)
                {
                    return InputMode.TouchOptimized;
                }

                // Otherwise -> Touch Enabled
                return InputMode.TouchEnabled;
            }
        }
    }
}
