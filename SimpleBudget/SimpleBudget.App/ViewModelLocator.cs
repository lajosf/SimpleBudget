using SimpleBudget.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.App
{
    class ViewModelLocator
    {
        private static MainWindowViewModel mainWindowViewModel
           = new MainWindowViewModel();

        public static MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return mainWindowViewModel;
            }
        }
    }
}
