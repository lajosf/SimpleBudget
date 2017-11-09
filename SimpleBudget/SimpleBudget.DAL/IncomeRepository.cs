using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBudget.Model;

namespace SimpleBudget.DAL
{
    public class IncomeRepository : IIncomeRepository
    {
        private List<Income> incomes;

        public void AddIncome(Income income)
        {
            throw new NotImplementedException();
        }

        public void DeleteIncome()
        {
            throw new NotImplementedException();
        }

        public List<Income> GetIncomes()
        {
            throw new NotImplementedException();
        }

        public void SetPeriodic(bool isPeriodic)
        {
            throw new NotImplementedException();
        }

        private void LoadIncomes()
        {
            incomes = new List<Income>() {
                new Income(){
                    IncomeId = 1,
                    Type = "Daddy salery",
                    Group = "Salery",
                    Amount = 10000,
                    Comment = "",
                    Periodic = true
                },
                new Income(){
                    IncomeId = 2,
                    Type = "Mommy salery",
                    Group = "Salery",
                    Amount = 12000,
                    Comment = "",
                    Periodic = true
                }
            };
        }
    }
}
