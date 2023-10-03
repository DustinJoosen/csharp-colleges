using College4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace College4.ViewModel
{
    public class CalculatorViewModel : Calculator
    {
        public ICommand NumericalKeyPressed { get; set; }
        public ICommand OperatorKeyPressed { get; set; }
        public ICommand ActiveAction { get; set; }

        public CalculatorViewModel()
        {
            this.NumericalKeyPressed = new RelayCommand(ExecuteNumericalKeyPressed, DefaultReturnTruePredicate);
            this.OperatorKeyPressed = new RelayCommand(ExecuteOperatorKeyPressed, DefaultReturnTruePredicate);
            this.ActiveAction = new RelayCommand(ExecuteActiveAction, DefaultReturnTruePredicate);
        }

        public void ExecuteNumericalKeyPressed(object parameter)
        {
            int numerical_value = Convert.ToInt32((string)parameter);
            this.Formula += numerical_value;
        }

        public void ExecuteOperatorKeyPressed(object parameter)
        {
            string value = (string)parameter;
            this.Formula += value;
        }

        public void ExecuteActiveAction(object parameter)
        {
            switch (parameter)
            {
                case "=":
                    this.ActiveActionEquals();
                    break;
                case "c":
                    this.Result = 0.0;
                    this.Formula = string.Empty;
                    break;
                case "b":
                    this.Formula = this.Formula.Substring(0, (this.Formula.Length - 1 > 0) ? this.Formula.Length - 1 : 0);
                    break;
                case "a":
                    this.Formula += this.Result;
                    break;
            }
        }

        private void ActiveActionEquals()
        {
            // calculate the actual result
            try
            {
                var value = Convert.ToDouble(new DataTable().Compute(this.Formula, string.Empty));
                this.Result = value;
            }
            catch { }
        }

        private bool DefaultReturnTruePredicate(object parameter) => true;
    }
}
