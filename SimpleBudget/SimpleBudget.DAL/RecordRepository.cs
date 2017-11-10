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
        private static List<Record> records;

        public List<Record> GetRecords()
        {
            if (records == null)
            {
                records = LoadRecords();
            }
            return records;
        }

        private List<Record> LoadRecords()
        {
            records = new List<Record>()
            {
                new Record()
                {
                    RecordId = 1,
                    Type = "Daddy salery",
                    Group = "Salery",
                    Amount = 10000,
                    Comment = "",
                    Periodic = true,
                    Date = new DateTime(2017,11,01)
                },
                new Record()
                {
                    RecordId = 2,
                    Type = "Mommy salery",
                    Group = "Salery",
                    Amount = 12000,
                    Comment = "",
                    Periodic = true,
                    Date = new DateTime(2017,11,01)
                },
                new Record()
                {
                    RecordId = 3,
                    Type = "Selling the car",
                    Group = "Sell",
                    Amount = 2000,
                    Comment = "",
                    Periodic = false,
                    Date = new DateTime(2017,11,06)
                }
            };
            return records;
        }
    }
}
