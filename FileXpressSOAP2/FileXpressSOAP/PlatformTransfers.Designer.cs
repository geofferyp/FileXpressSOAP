namespace FileXpressSOAP
{
    partial class PlatformTransfers
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
            this.groupBoxBankTransfers = new System.Windows.Forms.GroupBox();
            this.cmdGetAudit = new System.Windows.Forms.Button();
            this.cmdBankClear = new System.Windows.Forms.Button();
            this.cmdBankTransfer = new System.Windows.Forms.Button();
            this.comboBoxBankTransfers = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.groupBoxBankTransfers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBankTransfers
            // 
            this.groupBoxBankTransfers.Controls.Add(this.cmdGetAudit);
            this.groupBoxBankTransfers.Controls.Add(this.cmdBankClear);
            this.groupBoxBankTransfers.Controls.Add(this.cmdBankTransfer);
            this.groupBoxBankTransfers.Controls.Add(this.comboBoxBankTransfers);
            this.groupBoxBankTransfers.Location = new System.Drawing.Point(9, 6);
            this.groupBoxBankTransfers.Name = "groupBoxBankTransfers";
            this.groupBoxBankTransfers.Size = new System.Drawing.Size(799, 368);
            this.groupBoxBankTransfers.TabIndex = 0;
            this.groupBoxBankTransfers.TabStop = false;
            this.groupBoxBankTransfers.Text = "Pre-Defiend Transfers";
            // 
            // cmdGetAudit
            // 
            this.cmdGetAudit.Location = new System.Drawing.Point(340, 307);
            this.cmdGetAudit.Name = "cmdGetAudit";
            this.cmdGetAudit.Size = new System.Drawing.Size(163, 41);
            this.cmdGetAudit.TabIndex = 3;
            this.cmdGetAudit.Text = "Get Audit";
            this.cmdGetAudit.UseVisualStyleBackColor = true;
            this.cmdGetAudit.Click += new System.EventHandler(this.cmdGetAudit_Click);
            // 
            // cmdBankClear
            // 
            this.cmdBankClear.Location = new System.Drawing.Point(209, 307);
            this.cmdBankClear.Name = "cmdBankClear";
            this.cmdBankClear.Size = new System.Drawing.Size(113, 41);
            this.cmdBankClear.TabIndex = 2;
            this.cmdBankClear.Text = "Clear";
            this.cmdBankClear.UseVisualStyleBackColor = true;
            // 
            // cmdBankTransfer
            // 
            this.cmdBankTransfer.Location = new System.Drawing.Point(12, 307);
            this.cmdBankTransfer.Name = "cmdBankTransfer";
            this.cmdBankTransfer.Size = new System.Drawing.Size(179, 41);
            this.cmdBankTransfer.TabIndex = 1;
            this.cmdBankTransfer.Text = "Excecute";
            this.cmdBankTransfer.UseVisualStyleBackColor = true;
            this.cmdBankTransfer.Click += new System.EventHandler(this.cmdBankTransfer_Click_1);
            // 
            // comboBoxBankTransfers
            // 
            this.comboBoxBankTransfers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBankTransfers.FormattingEnabled = true;
            this.comboBoxBankTransfers.Location = new System.Drawing.Point(11, 51);
            this.comboBoxBankTransfers.Name = "comboBoxBankTransfers";
            this.comboBoxBankTransfers.Size = new System.Drawing.Size(770, 39);
            this.comboBoxBankTransfers.TabIndex = 0;
            this.comboBoxBankTransfers.SelectedIndexChanged += new System.EventHandler(this.comboBoxBankTransfers_SelectedIndexChanged);
            this.comboBoxBankTransfers.Click += new System.EventHandler(this.comboBoxBankTransfers_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 405);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 32);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: ";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(899, 320);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(148, 50);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(899, 264);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(148, 50);
            this.cmdHelp.TabIndex = 4;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            this.cmdHelp.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(899, 206);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(148, 50);
            this.cmdBack.TabIndex = 5;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // PlatformTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 540);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxBankTransfers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlatformTransfers";
            this.Text = "PlatformTransfers";
            this.Load += new System.EventHandler(this.PlatformTransfers_Load);
            this.groupBoxBankTransfers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBankTransfers;
        private System.Windows.Forms.Button cmdBankClear;
        private System.Windows.Forms.Button cmdBankTransfer;
        private System.Windows.Forms.ComboBox comboBoxBankTransfers;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.Button cmdGetAudit;
    }
}