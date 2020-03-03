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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                DialogResult result = MessageBox.Show("Enter an account and/or password.", "Error", MessageBoxButtons.OK);
                /*if (result == System.Windows.Forms.DialogResult.OK)
                {
                    
                }*/
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                    UsernameLabel.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(PasswordTextBox.Text))
                    PasswordLabel.ForeColor = Color.Red;
            }
            else
            {
                string username = UsernameTextBox.Text;
                string password = PasswordTextBox.Text;

                Console.WriteLine($"Username: {username}\nPassword: {password}");

                //DB Connection
                this.Hide();
                DashboardForm dbForm = new DashboardForm();
                dbForm.Show();
            }
        }

        private void TextBox_Focus(object sender, EventArgs e)
        {
            TextBox obj = sender as TextBox;
            switch (obj.TabIndex)
            {
                case 1:
                    UsernameLabel.ForeColor = Color.Black;
                    break;
                case 2:
                    PasswordLabel.ForeColor = Color.Black;
                    break;
            }
        }

        private void KeyEnter_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e as EventArgs);
            }
        }
    }
}
