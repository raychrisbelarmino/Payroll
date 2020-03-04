using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class EmployeeModel : INotifyPropertyChanged
    {

        string _ID { get; set; }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged(nameof(ID)); }
        }

        string _FName { get; set; }
        public string FName
        {
            get { return _FName; }
            set{_FName = value; OnPropertyChanged(nameof(FName));}
        }

        string _LName { get; set; }
        public string LName
        {
            get { return _LName; }
            set { _LName = value; OnPropertyChanged(nameof(LName)); }
        }

        string _DateStarted { get; set; }
        public string DateStarted
        {
            get { return _DateStarted; }
            set { _DateStarted = value; OnPropertyChanged(nameof(DateStarted)); }
        }

        ObservableCollection<EmployeeDeductionsModel> _Deductions { get; set; }
        public ObservableCollection<EmployeeDeductionsModel> Deductions
        {
            get { return _Deductions; }
            set { _Deductions = value; OnPropertyChanged(nameof(Deductions)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class EmployeeDeductionsModel : INotifyPropertyChanged
    {

        string _ID { get; set; }
        public string ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged(nameof(ID)); }
        }

        string _Name { get; set; }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(nameof(Name)); }
        }

        double _Amount { get; set; }
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; OnPropertyChanged(nameof(Amount)); }
        }

        string _DateStarted { get; set; }
        public string DateStarted
        {
            get { return _DateStarted; }
            set { _DateStarted = value; OnPropertyChanged(nameof(DateStarted)); }
        }

        bool _IsDone { get; set; }
        public bool IsDone
        {
            get { return _IsDone; }
            set { _IsDone = value; OnPropertyChanged(nameof(IsDone)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
