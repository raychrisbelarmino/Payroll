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
    public partial class PersonalizedDeductionForm : Form
    {
        EmployeeModel employee = new EmployeeModel();
        int initialy = 57, initialAx = 19, initialBx = 258, initialCx = 377, initialDx = 504, initialEx = 582, cnt = 0;

        public PersonalizedDeductionForm(EmployeeModel e)
        {
            InitializeComponent();
            employee = e;
            PersonalHeader.Text = $"{employee.ID} - {employee.LName}, {employee.FName}";
            PopulateDeductions();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.Controls.Clear();
        }

        void PopulateDeductions()
        {
            if(employee.Deductions.Count > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Amount");
                dt.Columns.Add("Date");
                foreach (var e in employee.Deductions.ToList())
                {
                    if (!e.IsDone)
                    {
                        cnt++;
                        TextBox txtBox1 = CreateTextBox("deductName" + cnt, e.Name, new Point(initialAx, initialy), 233);
                        TextBox txtBox2 = CreateTextBox("deductAmount" + cnt, String.Format("{0:0.00}", e.Amount), new Point(initialBx, initialy), 113);
                        TextBox txtBox3 = CreateTextBox("deductDate" + cnt, e.DateStarted, new Point(initialCx, initialy), 110);

                        Button btn1 = CreateButton("deductSave" + cnt, "Save", new Point(initialDx, initialy), 72, 26);
                        btn1.Click += BtnSave_Click;

                        Button btn2 = CreateButton("deductDelete" + cnt, "Delete", new Point(initialEx, initialy), 76, 26);
                        btn2.Click += BtnDel_Click;

                        initialy += 30;

                        splitterCont.Panel1.Controls.Add(txtBox1);
                        splitterCont.Panel1.Controls.Add(txtBox2);
                        splitterCont.Panel1.Controls.Add(txtBox3);
                        splitterCont.Panel1.Controls.Add(btn1);
                        splitterCont.Panel1.Controls.Add(btn2);
                    }
                    else
                    {
                        dt.Rows.Add(new object[] { e.Name, e.Amount, e.DateStarted });
                    }
                }
                DoneDeductionsDataGrid.DataSource = dt;
                DoneDeductionsDataGrid.Columns[0].Width = 241;
                DoneDeductionsDataGrid.Columns[1].Width = 241;
                DoneDeductionsDataGrid.Columns[2].Width = 134;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            cnt++;
            TextBox txtBox1 = CreateTextBox("deductName" + cnt, "Deduction name", new Point(initialAx, initialy), 233);
            TextBox txtBox2 = CreateTextBox("deductAmount" + cnt, "0.00", new Point(initialBx, initialy), 113);
            TextBox txtBox3 = CreateTextBox("deductDate" + cnt, "01/2000", new Point(initialCx, initialy), 110);

            Button btn1 = CreateButton("deductSave" + cnt, "Save", new Point(initialDx, initialy), 72, 26);
            btn1.Click += BtnSave_Click;

            Button btn2 = CreateButton("deductDelete" + cnt, "Delete", new Point(initialEx, initialy), 76, 26);
            btn2.Click += BtnDel_Click;

            initialy += 30;

            splitterCont.Panel1.Controls.Add(txtBox1);
            splitterCont.Panel1.Controls.Add(txtBox2);
            splitterCont.Panel1.Controls.Add(txtBox3);
            splitterCont.Panel1.Controls.Add(btn1);
            splitterCont.Panel1.Controls.Add(btn2);

            employee.Deductions.Add(new EmployeeDeductionsModel() {
                ID = cnt.ToString(),
                Name = txtBox1.Text,
                Amount = Convert.ToDouble(txtBox2.Text),
                DateStarted = txtBox3.Text,
                IsDone = false
            });

            //save to db
            DialogResult result = MessageBox.Show("Personal deduction added.", "", MessageBoxButtons.OK);
        }
    
        TextBox CreateTextBox(string name, string text, Point loc, int width)
        {
            TextBox textBox = new TextBox();
            textBox.Name = name;
            textBox.Text = text;
            textBox.Location = loc;
            textBox.Font = new Font("Microsoft Sans Serif", 12);
            textBox.Width = width;

            return textBox;
        }

        Button CreateButton(string name, string text, Point loc, int width, int height)
        {
            Button button = new Button();
            button.Name = name;
            button.Text = text;
            button.Location = loc;
            button.Font = new Font("Microsoft Sans Serif", 12);
            button.Width = width;
            button.Height = height;

            return button;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int ndx = Convert.ToInt32((sender as Button).Name.Substring(10)) - 1;
            Console.WriteLine(ndx);

            employee.Deductions[ndx].Name = (this.Controls.Find($"deductName{ndx + 1}", true)[0] as TextBox).Text;
            employee.Deductions[ndx].Amount = Convert.ToDouble((this.Controls.Find($"deductAmount{ndx + 1}", true)[0] as TextBox).Text);
            employee.Deductions[ndx].DateStarted = (this.Controls.Find($"deductDate{ndx + 1}", true)[0] as TextBox).Text; ;

            //save to db
            DialogResult result = MessageBox.Show("Personal deduction saved.", "", MessageBoxButtons.OK);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int ndx = Convert.ToInt32((sender as Button).Name.Substring(12)) - 1;
            Console.WriteLine(ndx);

            employee.Deductions.RemoveAt(ndx);

            for(int x = 0; x < cnt; x++)
            {
                splitterCont.Panel1.Controls.Remove((this.Controls.Find($"deductName{x + 1}", true)[0] as TextBox));
                splitterCont.Panel1.Controls.Remove((this.Controls.Find($"deductAmount{x + 1}", true)[0] as TextBox));
                splitterCont.Panel1.Controls.Remove((this.Controls.Find($"deductDate{x + 1}", true)[0] as TextBox));
                splitterCont.Panel1.Controls.Remove((this.Controls.Find($"deductSave{x + 1}", true)[0] as Button));
                splitterCont.Panel1.Controls.Remove((this.Controls.Find($"deductDelete{x + 1}", true)[0] as Button));
            }
            initialy = 57;
            cnt = 0;

            PopulateDeductions();

            //save to db
            DialogResult result = MessageBox.Show("Personal deduction deleted.", "", MessageBoxButtons.OK);
        }
    }
}
