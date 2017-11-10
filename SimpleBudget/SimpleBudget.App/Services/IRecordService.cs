using SimpleBudget.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.App.Services
{
    interface IRecordService
    {
        void AddRecord(Record record);
        void DeleteRecord(Record record);
        ObservableCollection<Record> GetAllRecords();
        void UpdateRecord(Record record);
    }
}
