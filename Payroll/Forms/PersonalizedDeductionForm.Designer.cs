namespace Payroll
{
    partial class PersonalizedDeductionForm
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DeductionNameLabel = new System.Windows.Forms.Label();
            this.splitterCont = new System.Windows.Forms.SplitContainer();
            this.PersonalHeader = new System.Windows.Forms.Label();
            this.DoneDeductionsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitterCont)).BeginInit();
            this.splitterCont.Panel1.SuspendLayout();
            this.splitterCont.Panel2.SuspendLayout();
            this.splitterCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoneDeductionsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(255, 40);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(582, 3);
            this.button1.MaximumSize = new System.Drawing.Size(75, 30);
            this.button1.MinimumSize = new System.Drawing.Size(75, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(374, 40);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(83, 13);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Month and Year";
            // 
            // DeductionNameLabel
            // 
            this.DeductionNameLabel.AutoSize = true;
            this.DeductionNameLabel.Location = new System.Drawing.Point(16, 40);
            this.DeductionNameLabel.Name = "DeductionNameLabel";
            this.DeductionNameLabel.Size = new System.Drawing.Size(56, 13);
            this.DeductionNameLabel.TabIndex = 4;
            this.DeductionNameLabel.Text = "Deduction";
            // 
            // splitterCont
            // 
            this.splitterCont.Location = new System.Drawing.Point(12, 12);
            this.splitterCont.Name = "splitterCont";
            this.splitterCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitterCont.Panel1
            // 
            this.splitterCont.Panel1.AccessibleName = "Panel1";
            this.splitterCont.Panel1.AutoScroll = true;
            this.splitterCont.Panel1.Controls.Add(this.PersonalHeader);
            this.splitterCont.Panel1.Controls.Add(this.DeductionNameLabel);
            this.splitterCont.Panel1.Controls.Add(this.DateLabel);
            this.splitterCont.Panel1.Controls.Add(this.button1);
            this.splitterCont.Panel1.Controls.Add(this.AmountLabel);
            // 
            // splitterCont.Panel2
            // 
            this.splitterCont.Panel2.AccessibleName = "Panel2";
            this.splitterCont.Panel2.AutoScroll = true;
            this.splitterCont.Panel2.Controls.Add(this.DoneDeductionsDataGrid);
            this.splitterCont.Size = new System.Drawing.Size(660, 426);
            this.splitterCont.SplitterDistance = 303;
            this.splitterCont.TabIndex = 7;
            // 
            // PersonalHeader
            // 
            this.PersonalHeader.AutoSize = true;
            this.PersonalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PersonalHeader.Location = new System.Drawing.Point(15, 13);
            this.PersonalHeader.Name = "PersonalHeader";
            this.PersonalHeader.Size = new System.Drawing.Size(81, 20);
            this.PersonalHeader.TabIndex = 7;
            this.PersonalHeader.Text = "ID - Name";
            // 
            // DoneDeductionsDataGrid
            // 
            this.DoneDeductionsDataGrid.AllowUserToAddRows = false;
            this.DoneDeductionsDataGrid.AllowUserToDeleteRows = false;
            this.DoneDeductionsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DoneDeductionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoneDeductionsDataGrid.Location = new System.Drawing.Point(0, 3);
            this.DoneDeductionsDataGrid.Name = "DoneDeductionsDataGrid";
            this.DoneDeductionsDataGrid.ReadOnly = true;
            this.DoneDeductionsDataGrid.Size = new System.Drawing.Size(660, 116);
            this.DoneDeductionsDataGrid.TabIndex = 6;
            // 
            // PersonalizedDeductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.splitterCont);
            this.MaximumSize = new System.Drawing.Size(705, 489);
            this.MinimumSize = new System.Drawing.Size(705, 489);
            this.Name = "PersonalizedDeductionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalized Deductions";
            this.splitterCont.Panel1.ResumeLayout(false);
            this.splitterCont.Panel1.PerformLayout();
            this.splitterCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterCont)).EndInit();
            this.splitterCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoneDeductionsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label DeductionNameLabel;
        private System.Windows.Forms.SplitContainer splitterCont;
        private System.Windows.Forms.Label PersonalHeader;
        private System.Windows.Forms.DataGridView DoneDeductionsDataGrid;
    }
}