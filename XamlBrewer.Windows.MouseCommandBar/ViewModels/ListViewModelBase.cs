using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlBrewer.MouseCommandBar.ViewModels
{
    class ListViewModelBase<T> : ViewModelBase where T: ItemViewModelBase
    {
        private T selectedItem;

        public T SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (this.selectedItem != null)
                {
                    this.selectedItem.IsSelected = false;
                }

                this.SetProperty(ref this.selectedItem, value);

                if (this.selectedItem != null)
                {
                    this.selectedItem.IsSelected = true;
                }

                this.OnPropertyChanged("HasSelection");
            }
        }

        public bool HasSelection
        { get { return this.selectedItem != null; } }
    }
}
