namespace XamlBrewer.MouseCommandBar.ViewModels
{
    using System.Diagnostics;
    using System.Windows.Input;
    using Mvvm;

    class CheeseViewModel : ItemViewModelBase
    {
        private string name;
        private string description;

        public string Name
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        public string Description
        {
            get { return this.description; }
            set { this.SetProperty(ref this.description, value); }
        }

        public ICommand SmellCommand
        {
            get { return new RelayCommand(this.Smell_Executed); }
        }

        public ICommand EatComand
        {
            get { return new RelayCommand(this.Eat_Executed); }
        }

        private void Smell_Executed()
        {
            Debug.WriteLine("I just smelled the {0}.", this.name);
        }

        private void Eat_Executed()
        {
            Debug.WriteLine("I just ate some {0}.", this.name);
        }
    }
}
