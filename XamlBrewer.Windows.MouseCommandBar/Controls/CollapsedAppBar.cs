namespace XamlBrewer.MouseCommandBar
{
    using System.Collections.Generic;
    using System.Linq;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class CollapsedAppBar : Control
    {
        public CollapsedAppBar()
        {
            this.DefaultStyleKey = typeof(CollapsedAppBar);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.PointerEntered += CollapsedAppBar_PointerEntered;
            this.PointerExited += CollapsedAppBar_PointerExited;
            this.Tapped += CollapsedAppBar_Tapped;
        }

        private void CollapsedAppBar_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var page = this.GetFirstAncestorOfType<Page>();
            ShowAppBar(page.TopAppBar);
            ShowAppBar(page.BottomAppBar);
        }

        private void ShowAppBar(AppBar appBar)
        {
            if (appBar != null)
            {
                appBar.IsOpen = true;
            }
        }

        private void CollapsedAppBar_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "PointerOver", true);
        }

        private void CollapsedAppBar_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Normal", true);
        }
    }
}
