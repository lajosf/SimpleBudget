using SimpleBudget.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.DAL
{
    interface IRecordRepository
    {
        void AddRecord(Record income);
        void DeleteRecord(Record record);
        ObservableCollection<Record> GetRecords();
        void UpdateRecord(Record record);
    }
}
