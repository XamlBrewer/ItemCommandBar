namespace XamlBrewer.MouseCommandBar.ViewModels
{
    /// <summary>
    /// Base class for viewmodels that represent an item in a list.
    /// </summary>
    class ItemViewModelBase : ViewModelBase
    {
        private bool hasPointer = false;
        private bool isSelected;

        public bool IsSelected
        {
            get { return this.isSelected; }
            set
            {
                this.SetProperty(ref this.isSelected, value);
                // Update HasPointer if in TouchEnabled mode.
                if (this.InputMode == Services.InputMode.TouchEnabled)
                {
                    this.hasPointer = value;
                    this.OnPropertyChanged("HasPointer");
                }
            }
        }

        public bool HasPointer
        {
            get { return this.hasPointer; }
            set
            {
                // Behavior is only active in Desktop mode.
                if (this.InputMode == Services.InputMode.Desktop)
                {
                    this.SetProperty(ref this.hasPointer, value);
                }
            }
        }
    }
}
