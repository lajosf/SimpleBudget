using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBudget.Model;
using System.Collections.ObjectModel;

namespace SimpleBudget.DAL
{
    public class RecordRepository : IRecordRepository
    {
        private ObservableCollection<Record> records;

        public void AddRecord(Record income)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Record record)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Record> GetRecords()
        {
            if (records == null)
            {
                records = LoadRecords();
            }
            return records;
        }

        public void UpdateRecord(Record record)
        {
            throw new NotImplementedException();
        }

        private ObservableCollection<Record> LoadRecords()
        {
            records = new ObservableCollection<Record>()
            {
                new Record()
                {
                    RecordId = 1,
                    Type = "Daddy salery",
                    Group = "Salery",
                    Amount = 10000,
                    Comment = "",
                    Periodic = true
                },
                new Record()
                {
                    RecordId = 2,
                    Type = "Mommy salery",
                    Group = "Salery",
                    Amount = 12000,
                    Comment = "",
                    Periodic = true
                }
            };
            return records;
        }
    }
}
