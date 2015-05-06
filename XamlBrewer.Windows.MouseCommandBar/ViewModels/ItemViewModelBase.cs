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
            }
        }

        public bool HasPointer
        {
            get { return this.hasPointer; }
            set
            {
                if (this.InputMode == Services.InputMode.Desktop)
                {
                    this.SetProperty(ref this.hasPointer, value);
                }
            }
        }
    }
}
