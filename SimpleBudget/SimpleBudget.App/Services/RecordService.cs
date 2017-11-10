using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBudget.Model;
using SimpleBudget.DAL;
using System.Collections.ObjectModel;

namespace SimpleBudget.App.Services
{
    class RecordService : IRecordService
    {
        private RecordRepository repository;

        public RecordService() {
            repository = new RecordRepository();
        }

        public void AddRecord(Record record)
        {
            repository.AddRecord(record);
        }

        public void DeleteRecord(Record record)
        {
            repository.DeleteRecord(record);
        }

        public ObservableCollection<Record> GetAllRecords()
        {
            return repository.GetRecords();
        }

        public void UpdateRecord(Record record)
        {
            repository.UpdateRecord(record);
        }
    }
}
