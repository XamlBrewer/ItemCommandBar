namespace XamlBrewer.MouseCommandBar
{
    using Windows.UI.Xaml.Controls;
    using XamlBrewer.MouseCommandBar.ViewModels;

    public sealed partial class MainView : Page
    {
        public MainView()
        {
            this.InitializeComponent();
        }

        private void CheesePlate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = this.CheesePlate.SelectedItem as CheeseViewModel;
            if (selection == null)
            {
                this.CommandBar.IsOpen = false;
            }
            else
            {
                this.CommandBar.IsOpen = !selection.HasPointer;
            }
        }
    }
}
