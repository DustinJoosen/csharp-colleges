using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College4.Models
{
    public class Calculator : NotifyPropertyChanged
    {
        private double _result;
        public double Result
        {
            get => this._result;
            set
            {
                // Result is not displayed, but when formula is set, formula is updated with this value.
                this._result = value;
                this.Formula = value.ToString();
            }
        }

        private string _formula = string.Empty;
        public string Formula
        {
            get => this._formula;
            set
            {
                this._formula = value.ToString().Replace(",", ".");
                RaisePropertyChanged(nameof(Formula));
            }
        }
    }
}
