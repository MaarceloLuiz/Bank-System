namespace Bank___Week_5_class
{
    partial class Transfer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBalanceTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayTo = new System.Windows.Forms.Label();
            this.cboToAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFromAcc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmtFrom = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBalFrom = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDisplayFrom = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBalanceTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDisplayTo);
            this.groupBox1.Controls.Add(this.cboToAcc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFromAcc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmtFrom);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtBalFrom);
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblDisplayFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 503);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Funds";
            // 
            // txtBalanceTo
            // 
            this.txtBalanceTo.Location = new System.Drawing.Point(170, 371);
            this.txtBalanceTo.Name = "txtBalanceTo";
            this.txtBalanceTo.Size = new System.Drawing.Size(151, 22);
            this.txtBalanceTo.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Balance";
            // 
            // lblDisplayTo
            // 
            this.lblDisplayTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDisplayTo.Location = new System.Drawing.Point(27, 309);
            this.lblDisplayTo.Name = "lblDisplayTo";
            this.lblDisplayTo.Size = new System.Drawing.Size(382, 47);
            this.lblDisplayTo.TabIndex = 41;
            // 
            // cboToAcc
            // 
            this.cboToAcc.FormattingEnabled = true;
            this.cboToAcc.Location = new System.Drawing.Point(170, 267);
            this.cboToAcc.Name = "cboToAcc";
            this.cboToAcc.Size = new System.Drawing.Size(151, 24);
            this.cboToAcc.TabIndex = 40;
            this.cboToAcc.SelectedIndexChanged += new System.EventHandler(this.cboToAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Account To";
            // 
            // cboFromAcc
            // 
            this.cboFromAcc.FormattingEnabled = true;
            this.cboFromAcc.Location = new System.Drawing.Point(170, 41);
            this.cboFromAcc.Name = "cboFromAcc";
            this.cboFromAcc.Size = new System.Drawing.Size(151, 24);
            this.cboFromAcc.TabIndex = 38;
            this.cboFromAcc.SelectedIndexChanged += new System.EventHandler(this.cboFromAcc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Account From";
            // 
            // txtAmtFrom
            // 
            this.txtAmtFrom.Location = new System.Drawing.Point(170, 184);
            this.txtAmtFrom.Name = "txtAmtFrom";
            this.txtAmtFrom.Size = new System.Drawing.Size(151, 22);
            this.txtAmtFrom.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(248, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 51);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBalFrom
            // 
            this.txtBalFrom.Location = new System.Drawing.Point(170, 142);
            this.txtBalFrom.Name = "txtBalFrom";
            this.txtBalFrom.Size = new System.Drawing.Size(151, 22);
            this.txtBalFrom.TabIndex = 31;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(64, 421);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(108, 51);
            this.btnTransfer.TabIndex = 30;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Amount";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(47, 145);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 20;
            this.lblBalance.Text = "Balance";
            // 
            // lblDisplayFrom
            // 
            this.lblDisplayFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDisplayFrom.Location = new System.Drawing.Point(27, 79);
            this.lblDisplayFrom.Name = "lblDisplayFrom";
            this.lblDisplayFrom.Size = new System.Drawing.Size(382, 47);
            this.lblDisplayFrom.TabIndex = 19;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 528);
            this.Controls.Add(this.groupBox1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmtFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBalFrom;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDisplayFrom;
        private System.Windows.Forms.ComboBox cboFromAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayTo;
        private System.Windows.Forms.ComboBox cboToAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalanceTo;
        private System.Windows.Forms.Label label3;
    }
}