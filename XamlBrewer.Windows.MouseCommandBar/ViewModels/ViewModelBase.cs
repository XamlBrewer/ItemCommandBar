using Mvvm;
using XamlBrewer.MouseCommandBar.Services;

namespace XamlBrewer.MouseCommandBar.ViewModels
{
    class ViewModelBase : BindableBase
    {
        public InputMode InputMode
        {
            get { return Device.Instance.InputMode; }
            set
            {
                Device.Instance.InputMode = value;
                this.OnPropertyChanged("InputMode");
            }
        }
    }
}
