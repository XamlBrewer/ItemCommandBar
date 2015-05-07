namespace XamlBrewer.MouseCommandBar
{
    using System.Diagnostics;
    using Services;
    using Windows.UI.Xaml.Controls;

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

            this.ModeComboBox.SelectedIndex = (int)Device.Instance.InputMode;
        }

        private void CheesePlate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Device.Instance.InputMode == InputMode.TouchOptimized && e.AddedItems.Count == 1)
            {
                this.BottomAppBar.IsOpen = true;
            }
        }
    }
}
