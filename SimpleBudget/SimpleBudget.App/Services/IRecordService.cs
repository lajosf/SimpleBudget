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
        List<Record> GetAllRecords();
    }
}
