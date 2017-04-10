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
    public partial class SOAPDemo : Form
    {
        public SOAPDemo()
        {
            InitializeComponent();
        }
        public String userID = "admin";
        public String password = "password";
        public String token;
        public FXCC.AdminServiceService admin = new FXCC.AdminServiceService();
        public FileXpressSOAP.PlatformTransfers ptForm;


        //Pre-populate the comboBoxISTransfers with one so it looks better
        private void SOAPDemo_Load(object sender, EventArgs e)
        {
            comboBoxISTransfers.Items.Clear();
            comboBoxISTransfers.Items.Add("Download - Mortgage Application");
            comboBoxISTransfers.Show(); 
        }

        // Add a FileXpress Internet Server upload definition. Details from form
        public void addInternetUpload(String targetFolder)
        {
            try
            {

                FXCC.DateTime availDate = new FXCC.DateTime();
                availDate.year = DateTime.Now.Year;
                availDate.month = DateTime.Now.Month - 1;
                availDate.day = DateTime.Now.Day - 1;

                FXCC.Transfer xfer = new FXCC.Transfer();
                xfer.availableDate = availDate;
                xfer.clientFileName = "C:\\tmp\\localfile.txt";
                xfer.serverFileName = @"C:\in\" + targetFolder + @"\#(ClientFileName)";
                xfer.directoryTransfer = "1"; // 0 = no 1 = yes
                xfer.description = "SOAP Added Upload";
                xfer.authUserId = this.txtUser.Text;
                xfer.nodeName = "FXCC_PS";
                xfer.sendRecvFlag = "S"; // S = upload R = download
                xfer.allowableProtocol = "SECURE";
                xfer.conversionFlag = "0"; // 0 = Ascii to EBCDIC conversion 1 = ASCII to EBCDIC conversion based on local translation table
                xfer.notifyFlag = "1";    // 0 = No. 1 = send notify email.
                xfer.notifyEmailTemplate = "email-notification-template.xml";
                xfer.defaultNodeUserId = "administrator";
                xfer.defaultNodePwd = "password";
                xfer.defaultNTDomain = "FXCC";
                xfer.writeMode = "Z";
                xfer.FTPAlias = "/SOAPupload";
                xfer.oneTimeFlag = "0";  // The flag can be 0 for No, 1 for keep or 2 for Yes. 
                String fileId = admin.addTransfer(xfer, token);

                if (this.checkBoxOneTime.Checked == true)
                {

                    //String fileId = admin.addTransfer(xfer, token);
                    xfer.postActionFlag1 = "SR";
                    xfer.postActionType1 = "COMMAND";
                    xfer.postActionFlag2 = "SR";
                    xfer.postActionType2 = "COMMAND";
                    xfer.postActionData2 = @"c:\tools\fxadmin -removeuser " + txtUser.Text;
                    xfer.postActionData1 = @"c:\tools\fxadmin -removetransfer " + fileId;
                    admin.updateTransfer(xfer, fileId, token);
                    //this.lblStatus.Text = "Transfer was added [" + fileId + "]";
                }

                this.lblStatus.Text = "Transfer was added [" + fileId + "]";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        // Add a FileXpress Internet Server download definition. Details from form.
        public void addInternetDownload()
        {
            try
            {

                FXCC.DateTime availDate = new FXCC.DateTime();
                availDate.year = DateTime.Now.Year;
                availDate.month = DateTime.Now.Month - 1;
                availDate.day = DateTime.Now.Day - 1;

                FXCC.Transfer xfer = new FXCC.Transfer();
                xfer.availableDate = availDate;
                xfer.clientFileName = "C:\\tmp\\localfile.txt";
                xfer.serverFileName = @"C:\out\SOAP\";
                xfer.directoryTransfer = "1"; // 0 = no 1 = yes
                xfer.description = "SOAP Added Download";
                xfer.authUserId = this.txtUser.Text;
                xfer.nodeName = "FXCC_PS";
                xfer.sendRecvFlag = "R"; // S = upload R = download
                xfer.allowableProtocol = "SECURE";
                xfer.conversionFlag = "0"; // 0 = Ascii to EBCDIC conversion 1 = ASCII to EBCDIC conversion based on local translation table
                xfer.notifyFlag = "1";    // 0 = No. 1 = send notify email.
                xfer.notifyEmailTemplate = "email-notification-template.xml";
                xfer.defaultNodeUserId = "administrator";
                xfer.defaultNodePwd = "password";
                xfer.defaultNTDomain = "FXCC";
                xfer.writeMode = "Z";
                xfer.FTPAlias = "/SOAPdownload";
                xfer.oneTimeFlag = "0";  // The flag can be 0 for No, 1 for keep or 2 for Yes. 
                String fileId = admin.addTransfer(xfer, token);

                if (this.checkBoxOneTime.Checked == true)
                {


                    xfer.notifyFlag = "0";    // 0 = No. 1 = send notify email.
                    xfer.postActionFlag1 = "SR";
                    xfer.postActionType1 = "COMMAND";
                    xfer.postActionFlag2 = "SR";
                    xfer.postActionType2 = "COMMAND";
                    xfer.postActionData2 = @"c:\tools\fxadmin -removeuser " + txtUser.Text;
                    xfer.postActionData1 = @"c:\tools\fxadmin -removetransfer " + fileId;
                    admin.updateTransfer(xfer, fileId, token);
                    this.lblStatus.Text = "Transfer was added [" + fileId + "]";
                }
                else
                {
                    this.lblStatus.Text = "Transfer was added [" + fileId + "]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
   

        //Setup the selected transfer for the user
        private void cmdDefine_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" | comboBoxISTransfers.SelectedItem == null)
            {
                 MessageBox.Show(this, "Username and Transfer are required for a transfer setup.");
                return;
            }

            switch (comboBoxISTransfers.SelectedItem.ToString())
            {
                case "Download - Mortgage Application":
                    addInternetDownload();
                    break;
                
                case "Upload - Mortgage Application":
                    //MessageBox.Show("Work in Progress");
                    addInternetUpload("Mortgage");
                    break;

                case "Upload to Tech Support":
                    //MessageBox.Show("Work in Progress");
                    addInternetUpload("TechSupport");
                    break;
            }

            
            cmdDefine.Enabled = false;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Create the user with info from the form
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" | txtPass.Text == "" | txtUser.Text == "")
            {

                MessageBox.Show(this, "User name, password and email are required.");
                return;
            }

            admin.Url = "https://fxcc.fx.com:8443/fxcc/control?view=services/AdministratorService";
            admin.Credentials = new System.Net.NetworkCredential(userID, password);

            ServicePointManager.Expect100Continue = false;
           
            token = admin.getSession();
            

            if (token == null)
            {
                MessageBox.Show("Unable to connect to the Administrator Service!");
                return;
            }

            FXCC.User user = new FXCC.User();

            try
            {   // Set user properties           
                user.activeUserType = true;
                user.id = this.txtUser.Text;
                user.password = this.txtPass.Text;
                user.fullName = this.txtUser.Text;
                user.emailAddr = this.txtEmail.Text;
                FXCC.DateTime expDate = new FXCC.DateTime();
                expDate.year = 2099;
                expDate.month = 0;
                expDate.day = 31;
                user.expirationDate = expDate;
                user.pwdAllowSelfChange = ("1");
                user.pwdExpiresFlag = ("0");
                user.pwdForceChange = ("0");
                user.traceFlag = ("0");
                user.validDays = ("YYYYYYY");
                user.validEndTime = ("2350");
                user.validStartTime = ("0");
                user.visibility = ("public");
            //user.defaultRole = "TransferRight";


            //try
            //Add the user and set the file transfer right
                Boolean retval1 = admin.addUser(user, token);
                Boolean retval2 = admin.addUserToRole(txtUser.Text, "TransferRight", token);
                if(retval1 & retval2 == true)
                    {
                        this.lblStatus.Text = "Successfully added user " + user.id;
                        this.cmdCreate.Enabled = false;
                    }
                //else
                //    {
                //        lblStatus.Text = "Failed to add user " + user.id;
                //        txtEmail.Text = "";
                //        txtPass.Text = "";
                //        txtUser.Text = "";
                //    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                lblStatus.Text = "Failed to add user " + user.id;
                //txtEmail.Text = "";
                txtPass.Text = "";
                //txtUser.Text = "";
            }
            //admin.closeSession(token);
            //token = null;
        }

        //Clears User Panel
        private void cmdClear_Click(object sender, EventArgs e)
        {
            cmdCreate.Enabled = true;
            txtEmail.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void cmdClearTransferSetup_Click(object sender, EventArgs e)
        {
            comboBoxISTransfers.Items.Clear();
        }
        // **** Moved to new form
        //private void cmdBankClear_Click(object sender, EventArgs e)
        //{
        //    comboBoxBankTransfers.Items.Clear();
        //}


        //Load the combo box with a list of FileXpress Internet Server transfers
        private void comboISTransfers_Click(object sender, EventArgs e)
        {
            comboBoxISTransfers.Items.Clear();
            comboBoxISTransfers.Items.Add("Download - Mortgage Application");
            comboBoxISTransfers.Items.Add("Upload - Mortgage Application");
            //comboBoxISTransfers.Items.Add("Upload to Tech Support");
            comboBoxISTransfers.Items.Add("Upload to Tech Support");
            //comboBoxISTransfers.Items.Add("Outbound - Transaction Records");
            //comboBoxISTransfers.SelectedItem = "Outbound - Mortgage Application";
           comboBoxISTransfers.Show();   
        }

        private void comboBoxISTransfers_DropDownClosed(Object sender, EventArgs e)
        {
            if (comboBoxISTransfers.SelectedItem == null)
            {
                cmdDefine.Enabled = false;
            }
            else
            {
                cmdDefine.Enabled = true;
            }
        }


        //***** Moved to new form             
        //private void comboBoxBankTransfers_Click(object sender, EventArgs e)
        //{
        //    comboBoxBankTransfers.Items.Clear();
        //    if (token == null)
        //    {
        //        admin.Url = "https://fxcc.fx.com:8443/fxcc/control?view=services/AdministratorService";
        //        admin.Credentials = new System.Net.NetworkCredential(userID, password);

        //        ServicePointManager.Expect100Continue = false;
        //        token = admin.getSession();
        //    }

        //    FXCC.FTTransfer[] bank = admin.retrieveAllTransfersFromBank(token);

        //    comboBoxBankTransfers.Enabled = true;
        //    int count = 0;
        //    foreach (FXCC.FTTransfer ftTransfer in bank)
        //    {
        //        if (bank[count] != null)
        //        {

        //            comboBoxBankTransfers.Items.Add(bank[count].description);
        //            count++;


        //        }
        //        comboBoxBankTransfers.Visible = true;
        //    }

                    
        }
        //**** Moved to new Form
        //private void cmdBankTransfer_Click(object sender, EventArgs e)
        //{
        //    comboBoxISTransfers.Items.Clear();
        //    FXCC.FTTransfer[] bank = admin.retrieveAllTransfersFromBank(token);
        //    int bankNum = comboBoxBankTransfers.SelectedIndex;
        //    string retval = admin.submitTransferToServer(bank[bankNum], token);
        //    //retval.Replace("\n", "\r\n");
        //    lblStatus.Text = retval;
        //    //lblStatus.Text = "A really long ugly message with many many many linefeeds and then more linefeeds\r\nFoobar Rules";
        //    //comboBoxBankTransfers.
        //}

        private void cmdMore_Click(object sender, EventArgs e)
        {
            ptForm = new PlatformTransfers();
            ptForm.FormClosed += new FormClosedEventHandler(ptForm_FormClosed);
            this.Hide();            
            ptForm.Show();            
        }

        private void ptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }




        //private void comboBoxISTransfers_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if ((String)comboBoxISTransfers.SelectedItem == null)
        //    {
        //        cmdDefine.Enabled = false;
        //    }
        //    else
        //    {
        //        cmdDefine.Enabled = true;
        //    }
        //}

        private void comboBoxISTransfers_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((String)comboBoxISTransfers.SelectedItem == null)
            {
                cmdDefine.Enabled = false;
            }
            else
            {
                cmdDefine.Enabled = true;
            }
        }

        private void groupBoxUser_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxISTransfers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



 
    }
}
