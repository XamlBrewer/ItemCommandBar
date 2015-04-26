namespace XamlBrewer.MouseCommandBar.ViewModels
{
    using Mvvm;
    using System.Diagnostics;
    using System.Windows.Input;

    class CheeseViewModel : BindableBase
    {
        private string name;
        private string description;
        private bool hasPointer = false;

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

        public bool HasPointer
        {
            get { return this.hasPointer; }
            set { this.SetProperty(ref this.hasPointer, value); }
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
