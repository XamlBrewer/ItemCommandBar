using Mvvm;
using XamlBrewer.MouseCommandBar.Services;

namespace XamlBrewer.MouseCommandBar.ViewModels
{
    class ViewModelBase : BindableBase
    {
        public InputMode InputMode
        {
            get { return Device.InputMode; }
        }
    }
}
