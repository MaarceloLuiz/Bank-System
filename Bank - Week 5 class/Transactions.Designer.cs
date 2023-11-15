namespace Bank___Week_5_class
{
    partial class Transactions
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
            this.dgvAcc = new System.Windows.Forms.DataGridView();
            this.btnAllAcc = new System.Windows.Forms.Button();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.btnAccAbove = new System.Windows.Forms.Button();
            this.cboGen = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.AllTransactionsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcc
            // 
            this.dgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcc.Location = new System.Drawing.Point(12, 204);
            this.dgvAcc.Name = "dgvAcc";
            this.dgvAcc.RowHeadersWidth = 51;
            this.dgvAcc.RowTemplate.Height = 24;
            this.dgvAcc.Size = new System.Drawing.Size(776, 317);
            this.dgvAcc.TabIndex = 0;
            // 
            // btnAllAcc
            // 
            this.btnAllAcc.Location = new System.Drawing.Point(24, 26);
            this.btnAllAcc.Name = "btnAllAcc";
            this.btnAllAcc.Size = new System.Drawing.Size(124, 53);
            this.btnAllAcc.TabIndex = 1;
            this.btnAllAcc.Text = "All Accounts";
            this.btnAllAcc.UseVisualStyleBackColor = true;
            this.btnAllAcc.Click += new System.EventHandler(this.btnAllAcc_Click);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(172, 35);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(154, 22);
            this.txtAmt.TabIndex = 2;
            // 
            // btnAccAbove
            // 
            this.btnAccAbove.Location = new System.Drawing.Point(341, 26);
            this.btnAccAbove.Name = "btnAccAbove";
            this.btnAccAbove.Size = new System.Drawing.Size(124, 53);
            this.btnAccAbove.TabIndex = 3;
            this.btnAccAbove.Text = "Acc Above";
            this.btnAccAbove.UseVisualStyleBackColor = true;
            this.btnAccAbove.Click += new System.EventHandler(this.btnAccAbove_Click);
            // 
            // cboGen
            // 
            this.cboGen.FormattingEnabled = true;
            this.cboGen.Location = new System.Drawing.Point(482, 35);
            this.cboGen.Name = "cboGen";
            this.cboGen.Size = new System.Drawing.Size(151, 24);
            this.cboGen.TabIndex = 4;
            this.cboGen.SelectedIndexChanged += new System.EventHandler(this.cboGen_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(648, 26);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 53);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // AllTransactionsbtn
            // 
            this.AllTransactionsbtn.Location = new System.Drawing.Point(341, 129);
            this.AllTransactionsbtn.Name = "AllTransactionsbtn";
            this.AllTransactionsbtn.Size = new System.Drawing.Size(124, 53);
            this.AllTransactionsbtn.TabIndex = 6;
            this.AllTransactionsbtn.Text = "All Transactions";
            this.AllTransactionsbtn.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 533);
            this.Controls.Add(this.AllTransactionsbtn);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboGen);
            this.Controls.Add(this.btnAccAbove);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.btnAllAcc);
            this.Controls.Add(this.dgvAcc);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcc;
        private System.Windows.Forms.Button btnAllAcc;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Button btnAccAbove;
        private System.Windows.Forms.ComboBox cboGen;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button AllTransactionsbtn;
    }
}