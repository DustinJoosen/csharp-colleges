using College4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace College4.ViewModel
{
    public class MainWindowViewModel : User
    {
        public ICommand ToUpperButton { get; set; }
        public ICommand DoTheThing { get; set; }

        public MainWindowViewModel()
        {
            this.FirstName = "Dustin";
            this.LastName = "Joosen";

            this.ToUpperButton = new RelayCommand(Execute, CanExecute);
            this.DoTheThing = new RelayCommand(DoIt, CanExecute);
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

        private void Execute(object parameter)
        {
            this.FirstName = this.FirstName.ToUpper();
            this.LastName = this.LastName.ToUpper();
        }

        private void DoIt(object prarameter)
        {
            this.LastName += " (of the white house)";
        }
    }
}
