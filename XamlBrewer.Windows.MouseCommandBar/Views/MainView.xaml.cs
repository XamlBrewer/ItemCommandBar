namespace XamlBrewer.MouseCommandBar
{
    using System.Diagnostics;
    using Windows.UI.Xaml.Controls;
    using Services;

    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
            Debug.WriteLine("I sense the presence of a mouse: {0}.", new Windows.Devices.Input.MouseCapabilities().MousePresent > 0);
            Debug.WriteLine("I sense the presence of a keyboard: {0}.", new Windows.Devices.Input.KeyboardCapabilities().KeyboardPresent > 0);
            Debug.WriteLine("I sense the presence of a touch screen: {0}.", new Windows.Devices.Input.TouchCapabilities().TouchPresent > 0);

            this.ModeTextBlock.Text = "Mode: " + Device.InputMode;
        }
    }
}
