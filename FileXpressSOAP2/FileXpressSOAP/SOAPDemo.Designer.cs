namespace FileXpressSOAP
{
    partial class SOAPDemo
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTransfer = new System.Windows.Forms.GroupBox();
            this.checkBoxOneTime = new System.Windows.Forms.CheckBox();
            this.cmdDefine = new System.Windows.Forms.Button();
            this.comboBoxISTransfers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxBanks = new System.Windows.Forms.GroupBox();
            this.comboBoxBankTransfers = new System.Windows.Forms.ComboBox();
            this.cmdBankClear = new System.Windows.Forms.Button();
            this.cmdBankTransfer = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdHelp = new System.Windows.Forms.Button();
            this.cmdMore = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.cmdClear);
            this.groupBoxUser.Controls.Add(this.cmdCreate);
            this.groupBoxUser.Controls.Add(this.txtEmail);
            this.groupBoxUser.Controls.Add(this.lblEmail);
            this.groupBoxUser.Controls.Add(this.txtPass);
            this.groupBoxUser.Controls.Add(this.txtUser);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(20, 16);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(435, 290);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Create User";
            this.groupBoxUser.Enter += new System.EventHandler(this.groupBoxUser_Enter);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(295, 229);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(119, 34);
            this.cmdClear.TabIndex = 17;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(179, 229);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(102, 34);
            this.cmdCreate.TabIndex = 16;
            this.cmdCreate.Text = "OK";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 39);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 32);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(176, 108);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(253, 39);
            this.txtPass.TabIndex = 13;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(176, 63);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(253, 39);
            this.txtUser.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "User name:";
            // 
            // groupBoxTransfer
            // 
            this.groupBoxTransfer.Controls.Add(this.checkBoxOneTime);
            this.groupBoxTransfer.Controls.Add(this.cmdDefine);
            this.groupBoxTransfer.Controls.Add(this.comboBoxISTransfers);
            this.groupBoxTransfer.Controls.Add(this.label3);
            this.groupBoxTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransfer.Location = new System.Drawing.Point(494, 16);
            this.groupBoxTransfer.Name = "groupBoxTransfer";
            this.groupBoxTransfer.Size = new System.Drawing.Size(514, 287);
            this.groupBoxTransfer.TabIndex = 1;
            this.groupBoxTransfer.TabStop = false;
            this.groupBoxTransfer.Text = "Setup Transfer for this User";
            // 
            // checkBoxOneTime
            // 
            this.checkBoxOneTime.AutoSize = true;
            this.checkBoxOneTime.Location = new System.Drawing.Point(6, 205);
            this.checkBoxOneTime.Name = "checkBoxOneTime";
            this.checkBoxOneTime.Size = new System.Drawing.Size(288, 36);
            this.checkBoxOneTime.TabIndex = 7;
            this.checkBoxOneTime.Text = "One time transfer";
            this.checkBoxOneTime.UseVisualStyleBackColor = true;
            // 
            // cmdDefine
            // 
            this.cmdDefine.Location = new System.Drawing.Point(372, 197);
            this.cmdDefine.Name = "cmdDefine";
            this.cmdDefine.Size = new System.Drawing.Size(98, 50);
            this.cmdDefine.TabIndex = 6;
            this.cmdDefine.Text = "OK";
            this.cmdDefine.UseVisualStyleBackColor = true;
            this.cmdDefine.Click += new System.EventHandler(this.cmdDefine_Click);
            // 
            // comboBoxISTransfers
            // 
            this.comboBoxISTransfers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxISTransfers.FormattingEnabled = true;
            this.comboBoxISTransfers.Location = new System.Drawing.Point(6, 43);
            this.comboBoxISTransfers.Name = "comboBoxISTransfers";
            this.comboBoxISTransfers.Size = new System.Drawing.Size(486, 39);
            this.comboBoxISTransfers.TabIndex = 2;
            this.comboBoxISTransfers.SelectedIndexChanged += new System.EventHandler(this.comboBoxISTransfers_SelectedIndexChanged);
            this.comboBoxISTransfers.DropDownClosed += new System.EventHandler(this.comboBoxISTransfers_DropDownClosed);
            this.comboBoxISTransfers.SelectedValueChanged += new System.EventHandler(this.comboBoxISTransfers_SelectedValueChanged);
            this.comboBoxISTransfers.Click += new System.EventHandler(this.comboISTransfers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(27, 309);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 32);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // groupBoxBanks
            // 
            this.groupBoxBanks.Enabled = false;
            this.groupBoxBanks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBanks.Name = "groupBoxBanks";
            this.groupBoxBanks.Size = new System.Drawing.Size(0, 0);
            this.groupBoxBanks.TabIndex = 22;
            this.groupBoxBanks.TabStop = false;
            this.groupBoxBanks.Visible = false;
            // 
            // comboBoxBankTransfers
            // 
            this.comboBoxBankTransfers.Location = new System.Drawing.Point(0, 0);
            this.comboBoxBankTransfers.Name = "comboBoxBankTransfers";
            this.comboBoxBankTransfers.Size = new System.Drawing.Size(121, 40);
            this.comboBoxBankTransfers.TabIndex = 0;
            // 
            // cmdBankClear
            // 
            this.cmdBankClear.Location = new System.Drawing.Point(0, 0);
            this.cmdBankClear.Name = "cmdBankClear";
            this.cmdBankClear.Size = new System.Drawing.Size(75, 23);
            this.cmdBankClear.TabIndex = 0;
            // 
            // cmdBankTransfer
            // 
            this.cmdBankTransfer.Location = new System.Drawing.Point(0, 0);
            this.cmdBankTransfer.Name = "cmdBankTransfer";
            this.cmdBankTransfer.Size = new System.Drawing.Size(75, 23);
            this.cmdBankTransfer.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(866, 392);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(120, 40);
            this.cmdCancel.TabIndex = 20;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdHelp
            // 
            this.cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHelp.Location = new System.Drawing.Point(580, 392);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(150, 39);
            this.cmdHelp.TabIndex = 19;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            // 
            // cmdMore
            // 
            this.cmdMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMore.Location = new System.Drawing.Point(736, 392);
            this.cmdMore.Name = "cmdMore";
            this.cmdMore.Size = new System.Drawing.Size(124, 40);
            this.cmdMore.TabIndex = 21;
            this.cmdMore.Text = "More...";
            this.cmdMore.UseVisualStyleBackColor = true;
            this.cmdMore.Click += new System.EventHandler(this.cmdMore_Click);
            // 
            // SOAPDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 504);
            this.Controls.Add(this.cmdMore);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.groupBoxBanks);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBoxTransfer);
            this.Controls.Add(this.groupBoxUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SOAPDemo";
            this.Text = "SOAPDemo";
            this.Load += new System.EventHandler(this.SOAPDemo_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxTransfer.ResumeLayout(false);
            this.groupBoxTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.GroupBox groupBoxTransfer;
        private System.Windows.Forms.ComboBox comboBoxISTransfers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdDefine;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxBanks;
        private System.Windows.Forms.Button cmdBankClear;
        private System.Windows.Forms.Button cmdBankTransfer;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.ComboBox comboBoxBankTransfers;
        private System.Windows.Forms.Button cmdMore;
        private System.Windows.Forms.CheckBox checkBoxOneTime;


    }
}