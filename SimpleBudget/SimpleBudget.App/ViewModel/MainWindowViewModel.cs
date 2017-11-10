using SimpleBudget.App.Extensions;
using SimpleBudget.App.Services;
using SimpleBudget.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBudget.App.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Record> records;
        private RecordService recordService;
        private Record selectedRecord;

        public MainWindowViewModel()
        {
            recordService = new RecordService();
            LoadData();
        }

        public ObservableCollection<Record> Records
        {
            get
            {
                return records;
            }
            set
            {
                records = value;
                RaisePropertyChanged("Records");
            }
        }

        public Record SelectedRecord {
            get
            {
                return selectedRecord;
            }
            set
            {
                selectedRecord = value;
                RaisePropertyChanged("SelectedRecord");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadData()
        {
            Records = recordService.GetAllRecords().ToObservableCollection();
        }
    }
}
