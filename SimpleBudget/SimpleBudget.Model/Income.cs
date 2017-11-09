using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.Model
{
    public class Income : INotifyPropertyChanged
    {
        private int incomeId;
        private string type;
        private string group;
        private int amount;
        private string comment;
        private bool periodic; 

        public int IncomeId
        {
            get
            {
                return incomeId;
            }
            set
            {
                incomeId = value;
                RaisePropertyChanged("IncomeId");
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                RaisePropertyChanged("Type");
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
                RaisePropertyChanged("Group");
            }
        }

        public int Amount {
            get {
                return amount;
            }
            set {
                amount = value;
                RaisePropertyChanged("Amount");
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                comment = value;
                RaisePropertyChanged("Comment");
            }
        }

        public bool Periodic
        {
            get
            {
                return periodic;
            }
            set
            {
                periodic = value;
                RaisePropertyChanged("Periodic");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
