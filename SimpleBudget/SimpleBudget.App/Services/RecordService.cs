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
        IRecordRepository repository;

        public RecordService() {
            this.repository = new RecordRepository();
        }

        public List<Record> GetAllRecords()
        {
            return repository.GetRecords();
        }
    }
}
