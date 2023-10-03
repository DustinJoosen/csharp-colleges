using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College4.Models
{
    public class User : NotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => this._id;
            set
            {
                this._id = value;
                this.RaisePropertyChanged("Id");
            }
        }

        private string _firstname;
        public string FirstName
        {
            get => this._firstname;
            set
            {
                this._firstname = value;
                this.RaisePropertyChanged("FirstName");
            }
        }

        private string _lastname;
        public string LastName
        {
            get => this._lastname;
            set
            {
                this._lastname = value;
                this.RaisePropertyChanged("LastName");
            }
        }

        private string _streetname;
        public string StreetName
        {
            get => this._streetname;
            set
            {
                this.StreetName = value;
                this.RaisePropertyChanged("StreetName");
            }
        }

        private int _streetnumber;
        public int StreetNumber
        {
            get => this._streetnumber;
            set
            {
                this._streetnumber = value;
                this.RaisePropertyChanged("StreetNumber");
            }
        }

        private string _city;
        public string City
        {
            get => this._city;
            set
            {
                this._city = value;
                this.RaisePropertyChanged("City");
            }
        }


        private string _postalnumber;
        public string PostalNumber
        {
            get => this._postalnumber;
            set
            {
                this._postalnumber = value;
                this.RaisePropertyChanged("PostalNumber");
            }
        }


    }
}
