namespace XamlBrewer.MouseCommandBar.ViewModels
{
    using System.Collections.Generic;

    class MainViewModel : ViewModelBase
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
                if (this.selectedCheese != null)
                {
                    this.selectedCheese.IsSelected = false;
                }

                this.SetProperty(ref this.selectedCheese, value);

                if (this.selectedCheese != null)
                {
                    this.selectedCheese.IsSelected = true;
                }
            }
        }
    }
}
