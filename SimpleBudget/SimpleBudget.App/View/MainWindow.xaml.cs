using SimpleBudget.Model;
using System;
using System.Collections.Generic;
using MahApps.Metro.Controls;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleBudget.App.Services;
using System.Collections.ObjectModel;

namespace SimpleBudget.App.View
{
    public partial class MainWindow : MetroWindow
    {
        private ObservableCollection<Record> records;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            dataGrid.ItemsSource = records;
        }

        private void LoadData() {
            RecordService service = new RecordService();
            records = service.GetAllRecords();
            //IncomeListView.ItemsSource = records;
        }

        private void SaveIncomeButton_Click(object sender, RoutedEventArgs e) {
            StringBuilder sb = new StringBuilder();

            foreach(Record record in records){
                sb.Append("Type: ");
                sb.Append(record.Type+" ");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
