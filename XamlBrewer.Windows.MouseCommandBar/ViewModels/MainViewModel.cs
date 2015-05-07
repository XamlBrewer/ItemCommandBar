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
                    new CheeseViewModel() { Name="Brie", Description="Q: What happened after an explosion at a French cheese factory?\nA: All that was left was de Brie."},
                    new CheeseViewModel() { Name="Stilton", Description="Q: What hotel do mice stay in ?\nA: The Stilton."},
                    new CheeseViewModel() { Name="Cheddar", Description="Q: When should you go on a cheese diet?\nA: If you need to Cheddar a few pounds."},
                    new CheeseViewModel() { Name="Curds", Description="Q: What group of cheese has been known to fly?\nA: Curds of prey!"}
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
