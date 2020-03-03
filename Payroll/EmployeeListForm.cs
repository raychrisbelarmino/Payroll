using System;
using System.Collections.Generic;
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
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dbForm = new DashboardForm();
            dbForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //search
            Console.WriteLine($"Search for {SearchTextBox.Text}");
        }
    }
}
