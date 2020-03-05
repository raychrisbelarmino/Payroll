using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class EmployeeListForm : Form
    {
        ObservableCollection<EmployeeModel> employeeList = new ObservableCollection<EmployeeModel>();
        public EmployeeListForm()
        {
            InitializeComponent();

            GetData();
            PopulateListView();
        }

        void GetData()//get data from DB
        {
            ObservableCollection<EmployeeDeductionsModel> employeeDeductions = new ObservableCollection<EmployeeDeductionsModel>();
            employeeDeductions.Add(new EmployeeDeductionsModel() { ID = "001", Name = "Pag-ibig Loan", Amount = 1000.00, DateStarted = "01/2000", IsDone = false });
            employeeDeductions.Add(new EmployeeDeductionsModel() { ID = "002", Name = "SSS Loan", Amount = 2000.00, DateStarted = "03/2000", IsDone = true });

            employeeList.Add(new EmployeeModel() { ID = "A1", LName = "Doe", FName = "John", DateStarted = "01/01/2020", Deductions = employeeDeductions });
            employeeList.Add(new EmployeeModel() { ID = "A2", LName = "Doe", FName = "Jane", DateStarted = "01/01/2020", Deductions = new ObservableCollection<EmployeeDeductionsModel>() });
            employeeList.Add(new EmployeeModel() { ID = "A3", LName = "Doe", FName = "Johnathan", DateStarted = "01/01/2020", Deductions = new ObservableCollection<EmployeeDeductionsModel>() });
            employeeList.Add(new EmployeeModel() { ID = "A4", LName = "Doe", FName = "Martha", DateStarted = "01/01/2020", Deductions = new ObservableCollection<EmployeeDeductionsModel>() });
            employeeList.Add(new EmployeeModel() { ID = "A5", LName = "Doe", FName = "Clark", DateStarted = "01/01/2020", Deductions = new ObservableCollection<EmployeeDeductionsModel>() });
        }

        void SearchData()//get data from DB
        {
            
        }

        void PopulateListView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Date");
            foreach (var e in employeeList)
            {
                dt.Rows.Add(new object[] { e.ID, e.LName, e.FName, e.DateStarted });
            }
            EmployeeDataGrid.DataSource = dt;
            EmployeeDataGrid.Columns[0].Width = 100;
            EmployeeDataGrid.Columns[1].Width = 241;
            EmployeeDataGrid.Columns[2].Width = 241;
            EmployeeDataGrid.Columns[3].Width = 151;

            EmployeeDataGrid.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            EmployeeDataGrid.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            EmployeeDataGrid.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            EmployeeDataGrid.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dbForm = new DashboardForm();
            dbForm.Show();
        }

        private void Cell_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string IDCellValue = EmployeeDataGrid[0, EmployeeDataGrid.CurrentRow.Index].Value.ToString();

                EmployeeModel employeeDetail = employeeList.Where(p => p.ID == IDCellValue).FirstOrDefault() as EmployeeModel;
                PersonalizedDeductionForm personalized = new PersonalizedDeductionForm(employeeDetail);
                personalized.Show();
            }
        }

        private void Cell_DoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string IDCellValue = EmployeeDataGrid[0, EmployeeDataGrid.CurrentRow.Index].Value.ToString();

                EmployeeModel employeeDetail = employeeList.Where(p => p.ID == IDCellValue).FirstOrDefault() as EmployeeModel;
                SalaryDetail openSD = new SalaryDetail(employeeDetail);
                openSD.Show();

            }
        }

        private void Text_Changed(object sender, EventArgs e)
        {
            Console.WriteLine($"Search for {SearchTextBox.Text}");
            employeeList.Clear();

            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                GetData();
                PopulateListView();
            }
            else
            {
                SearchData();
                PopulateListView();
            }
        }

        private void EmployeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cell_DoubleClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string IDCellValue = EmployeeDataGrid[0, EmployeeDataGrid.CurrentRow.Index].Value.ToString();

                EmployeeModel employeeDetail = employeeList.Where(p => p.ID == IDCellValue).FirstOrDefault() as EmployeeModel;
                SalaryDetail openSD = new SalaryDetail(employeeDetail);
                openSD.Show();

            }
        }
    }
}
