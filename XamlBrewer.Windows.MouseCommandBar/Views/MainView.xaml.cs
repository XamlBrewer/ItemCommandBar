namespace XamlBrewer.MouseCommandBar
{
    using System.Diagnostics;
    using Windows.UI.Xaml.Controls;
    using Services;
    using Windows.UI.Xaml;

    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
            this.ModeComboBox.Items.Add(InputMode.Desktop);
            this.ModeComboBox.Items.Add(InputMode.TouchEnabled);
            this.ModeComboBox.Items.Add(InputMode.TouchOptimized);

            Debug.WriteLine("I sense the presence of a mouse: {0}.", new Windows.Devices.Input.MouseCapabilities().MousePresent > 0);
            Debug.WriteLine("I sense the presence of a keyboard: {0}.", new Windows.Devices.Input.KeyboardCapabilities().KeyboardPresent > 0);
            Debug.WriteLine("I sense the presence of a touch screen: {0}.", new Windows.Devices.Input.TouchCapabilities().TouchPresent > 0);

            this.ModeComboBox.SelectedIndex = (int)Device.InputMode;
        }

        private void ApplyInputMode(InputMode inputMode)
        {
            switch (inputMode)
            {
                case InputMode.Desktop:
                    // No touch: no bottom appbar, inline appbar on item under pointer.
                    this.AppBarHint.Visibility = Visibility.Collapsed;
                    this.CommandBar.Visibility = Visibility.Collapsed;
                    break;
                case InputMode.TouchEnabled:
                    // Touch and mouse: no bottom appbar, inline appbar on selected item.
                    this.AppBarHint.Visibility = Visibility.Collapsed;
                    this.CommandBar.Visibility = Visibility.Collapsed;
                    break;
                case InputMode.TouchOptimized:
                    // No mouse: no inline appbar, bottom appbar opens and closes automatically.
                    this.AppBarHint.Visibility = Visibility.Visible;
                    this.CommandBar.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void ModeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var inputMode = (InputMode)this.ModeComboBox.SelectedItem;
            this.ApplyInputMode(inputMode);
        }
    }
}
