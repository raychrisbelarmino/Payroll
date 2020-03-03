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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            switch (obj.TabIndex)
            {
                case 1://Employee record
                    break;
                case 2://Nature of income
                    break;
                case 3://Settings
                    break;
                case 4://Reports
                    break;
                case 5://Deductions
                    break;
                case 6://Upload
                    break;
            }
        }
    }
}
