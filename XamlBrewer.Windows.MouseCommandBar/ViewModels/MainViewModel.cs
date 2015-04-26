namespace XamlBrewer.MouseCommandBar.ViewModels
{
    using Mvvm;
    using System.Collections.Generic;

    class MainViewModel : BindableBase
    {
        private CheeseViewModel selectedCheese;

        public List<CheeseViewModel> CheesePlate
        {
            get
            {
                return new List<CheeseViewModel>()
                {
                    new CheeseViewModel() { Name="Cheddar", Description="Blablabla"},
                    new CheeseViewModel() { Name="Emmentaler", Description="Blablabla"},
                    new CheeseViewModel() { Name="Gouda", Description="Blablabla"},
                    new CheeseViewModel() { Name="Monterey Jack", Description="Blablabla"}
                };
            }
        }

        public CheeseViewModel SelectedCheese
        {
            get { return this.selectedCheese; }
            set
            {
                this.SetProperty(ref this.selectedCheese, value);
                this.OnPropertyChanged("HasSelection");
            }
        }

        public bool HasSelection
        {
            get
            {
                return this.selectedCheese != null;
            }
        }
    }
}
