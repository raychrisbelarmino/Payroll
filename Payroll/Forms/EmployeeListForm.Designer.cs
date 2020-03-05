namespace Payroll
{
    partial class EmployeeListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackMenu
            // 
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(44, 20);
            this.BackMenu.Text = "Back";
            this.BackMenu.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddEmployeeButton.Location = new System.Drawing.Point(663, 37);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(125, 29);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.HeaderLabel.Location = new System.Drawing.Point(308, 40);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(185, 26);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "List of Employees";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchTextBox.Location = new System.Drawing.Point(395, 90);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(393, 26);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.Text_Changed);
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.AllowUserToAddRows = false;
            this.EmployeeDataGrid.AllowUserToDeleteRows = false;
            this.EmployeeDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Location = new System.Drawing.Point(12, 122);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.ReadOnly = true;
            this.EmployeeDataGrid.Size = new System.Drawing.Size(776, 316);
            this.EmployeeDataGrid.TabIndex = 5;
            this.EmployeeDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Clicked);
            this.EmployeeDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_DoubleClicked);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchLabel.Location = new System.Drawing.Point(329, 93);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(60, 20);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search";
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeList";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackMenu;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Label SearchLabel;
    }
}