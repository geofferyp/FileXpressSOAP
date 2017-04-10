using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


namespace FileXpressSOAP
{
    public partial class PlatformTransfers : Form
    {
        

        public PlatformTransfers()
        {
            InitializeComponent();
           
        }

        String userID = "admin";
        String password = "password";
        String token;
        public FXCC.AdminServiceService admin = new FXCC.AdminServiceService();
        FXCC.FTTransfer[] bank;

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PlatformTransfers_Load(object sender, EventArgs e)
        {
            comboBoxBankTransfers.Items.Add("Choose a Transfer");
        }

        private void cmdBankTransfer_Click(object sender, EventArgs e)
        {
            bank = admin.retrieveAllTransfersFromBank(token);
            int bankNum = comboBoxBankTransfers.SelectedIndex;
            string retval = admin.submitTransferToServer(bank[bankNum], token);
            //retval.Replace("\n", "\r\n");
            //***lblStatus.Text = retval;
            //lblStatus.Text = "A really long ugly message with many many many linefeeds and then more linefeeds\r\nFoobar Rules";
            //comboBoxBankTransfers.
        }
        
        //Get all the Platform Server transfers defined in the bank of transfers and load them into combobox
        private void comboBoxBankTransfers_Click(object sender, EventArgs e)
        {
            comboBoxBankTransfers.Items.Clear();
            if (token == null)
            {
                admin.Url = "https://fxcc.fx.com:8443/fxcc/control?view=services/AdministratorService";
                admin.Credentials = new System.Net.NetworkCredential(userID, password);

                ServicePointManager.Expect100Continue = false;
                token = admin.getSession();
            }

              bank = admin.retrieveAllTransfersFromBank(token);

                comboBoxBankTransfers.Enabled = true;
                int count = 0;
                foreach (FXCC.FTTransfer ftTransfer in bank)
                {
                    if (bank[count] != null)
                    {
                        comboBoxBankTransfers.Items.Add(bank[count].description);
                        count++;                    
                    }
                    comboBoxBankTransfers.Visible = true;
                }
            //admin.submitTransferToServer(bank[1], token);            
            }

        //Close the form
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        //    SOAPDemo myForm = new SOAPDemo();
        //    myForm.Close();
            
        }

        private void comboBoxBankTransfers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int bankNum = comboBoxBankTransfers.SelectedIndex;
            //string retval = admin.submitTransferToServer(bank[bankNum], token);
        }

        //Platform Server intiated transfers are called bank transfers in API
        //This method submits the selected transfer to be executed.
        private void cmdBankTransfer_Click_1(object sender, EventArgs e)
        {
            int bankNum = comboBoxBankTransfers.SelectedIndex;
            string retval = admin.submitTransferToServer(bank[bankNum], token);
            this.lblStatus.Text = retval;
            //string[] message = retval.Split(' ');
            //FXCC.AuditBase audit = admin.getAudit(message[2], token);
            //this.lblStatus.Text = retval;


        }

        //Get the audit message of the last transfer sumbitted.
        private void cmdGetAudit_Click(object sender, EventArgs e)
        {
            string[] message = this.lblStatus.Text.Split(' ');
            FXCC.AuditBase audit = admin.getAudit(message[1], token);
            this.lblStatus.Text = "Audit: " + audit.auditId + "Status: " + audit.transferStatus;
        }        
    }
}
