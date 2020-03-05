namespace Payroll
{
    partial class DashboardForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.DeductionsButton = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(345, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutFileMenu,
            this.ExitFileMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // LogoutFileMenu
            // 
            this.LogoutFileMenu.Name = "LogoutFileMenu";
            this.LogoutFileMenu.Size = new System.Drawing.Size(180, 22);
            this.LogoutFileMenu.Text = "Logout";
            this.LogoutFileMenu.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ExitFileMenu
            // 
            this.ExitFileMenu.Name = "ExitFileMenu";
            this.ExitFileMenu.Size = new System.Drawing.Size(180, 22);
            this.ExitFileMenu.Text = "Exit";
            this.ExitFileMenu.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RecordButton.Location = new System.Drawing.Point(59, 79);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(101, 50);
            this.RecordButton.TabIndex = 1;
            this.RecordButton.Text = "Employee Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SettingsButton.Location = new System.Drawing.Point(59, 227);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(101, 50);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // IncomeButton
            // 
            this.IncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IncomeButton.Location = new System.Drawing.Point(59, 155);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(101, 50);
            this.IncomeButton.TabIndex = 2;
            this.IncomeButton.Text = "Nature of Income";
            this.IncomeButton.UseVisualStyleBackColor = true;
            this.IncomeButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReportsButton.Location = new System.Drawing.Point(188, 79);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(102, 50);
            this.ReportsButton.TabIndex = 4;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // DeductionsButton
            // 
            this.DeductionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeductionsButton.Location = new System.Drawing.Point(188, 155);
            this.DeductionsButton.Name = "DeductionsButton";
            this.DeductionsButton.Size = new System.Drawing.Size(102, 50);
            this.DeductionsButton.TabIndex = 5;
            this.DeductionsButton.Text = "Deductions";
            this.DeductionsButton.UseVisualStyleBackColor = true;
            this.DeductionsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UploadButton.Location = new System.Drawing.Point(188, 227);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(102, 50);
            this.UploadButton.TabIndex = 6;
            this.UploadButton.Text = "Upload File";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 357);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.DeductionsButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.IncomeButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(361, 396);
            this.MinimumSize = new System.Drawing.Size(361, 396);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem LogoutFileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitFileMenu;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button DeductionsButton;
        private System.Windows.Forms.Button UploadButton;
    }
}