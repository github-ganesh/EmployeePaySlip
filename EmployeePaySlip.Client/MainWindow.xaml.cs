using EmployeePayslip.Model;
using EmployeePayslip.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace EmployeePaySlip.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        EmployeeSalaryService employeeSalaryService = null;
        IncomeTaxService incomeTaxService = null;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            employeeSalaryService = new EmployeeSalaryService();
            incomeTaxService = new IncomeTaxService();
            GetEmployeeDetails();
            EmployeesPayslip = new ObservableCollection<PaySlip>();
            PaySlipVisible = Visibility.Collapsed;
            this.DataContext = this;
        }
        public IEnumerable<EmployeeSalary> EmployeesSalary { get; set; }
        public ObservableCollection<PaySlip> EmployeesPayslip { get; set; }
        public Visibility PaySlipVisible { get; set; }

        private void GetEmployeeDetails()
        {
            
            EmployeesSalary = employeeSalaryService.GetEmployeeSalary();
        }
        private void GetPaySlip()
        {
            foreach (var item in EmployeesSalary)
            {
                EmployeesPayslip.Add(employeeSalaryService.GetPaySlip(item, incomeTaxService.CalculateTax(item.AnualSalary, DateTime.Now.Year), item.Period));
            }
            PaySlipVisible = Visibility.Visible;
            OnPropertyChanged("PaySlipVisible");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            GetPaySlip();
        }
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
