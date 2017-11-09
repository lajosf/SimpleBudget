using SimpleBudget.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.DAL
{
    interface IIncomeRepository
    {
        void AddIncome(Income income);
        void DeleteIncome();
        List<Income> GetIncomes();
        void SetPeriodic(bool isPeriodic);
    }
}
