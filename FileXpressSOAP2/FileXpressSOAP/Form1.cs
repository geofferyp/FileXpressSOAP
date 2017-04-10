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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String userID = "admin";
        String password = "password";
        String token;
        w2008cc.AdminServiceService admin = new w2008cc.AdminServiceService();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" | txtPass.Text == "" | txtUser.Text == "")
            {

                MessageBox.Show(this,"User name, password and email are required.");
                return;
            }

            admin.Url = "https://w2008cc:8443/fxcc/services/AdministratorService";
            admin.Credentials = new System.Net.NetworkCredential(userID, password);

            ServicePointManager.Expect100Continue = false;

            token = admin.getSession();

            //w2008cc.User usr = admin.getUser("admin", token);

            //MessageBox.Show(usr.ToString());

            w2008cc.User user = new w2008cc.User();
            user.activeUserType = true;
            user.id = this.txtUser.Text;
            user.password = this.txtPass.Text;
            user.fullName = this.txtUser.Text;
            user.emailAddr = this.txtEmail.Text;
            w2008cc.DateTime expDate = new w2008cc.DateTime();
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


            try
            {
                admin.addUser(user, token);
                admin.addUserToRole(txtUser.Text, "TransferRight", token);
                this.cmdCreate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }



        }

        public void addInternetTransfer()
        {

            w2008cc.DateTime availDate = new w2008cc.DateTime();
            availDate.year = DateTime.Now.Year;
            availDate.month = DateTime.Now.Month - 1;
            availDate.day = DateTime.Now.Day -1;

            w2008cc.Transfer xfer = new w2008cc.Transfer();
            xfer.availableDate = availDate;
            xfer.clientFileName = "C:\\tmp\\localfile.txt";
            xfer.serverFileName = @"C:\Users\Public\FileXpress\Incoming Sales\#(ClientFileName)";
            xfer.directoryTransfer ="1"; // 0 = no 1 = yes
            xfer.description = "SOAP Added Upload";
            xfer.authUserId = this.txtUser.Text;
            xfer.nodeName = "w2008cc_PS";
            xfer.sendRecvFlag = "S"; // S = upload R = download
            xfer.allowableProtocol = "SECURE";
            xfer.conversionFlag = "0"; // 0 = Ascii to EBCDIC conversion 1 = ASCII to EBCDIC conversion based on local translation table
            xfer.notifyFlag = "1";    // 0 = No. 1 = send notify email.
            xfer.notifyEmailTemplate = "email-notification-template-SOAP.xml";
            xfer.defaultNodeUserId = "administrator";
            xfer.defaultNodePwd = "password";
            xfer.defaultNTDomain = "w2008cc";
            xfer.writeMode = "Z";
            

                try

                {
                    String fileId = admin.addTransfer(xfer, token);
                    xfer.postActionFlag1 = "SR";
                    xfer.postActionType1 = "COMMAND";
                    xfer.postActionFlag2 = "SR";
                    xfer.postActionType2 = "COMMAND";
                    xfer.postActionData2 = @"c:\tools\fxadmin -removeuser " + txtUser.Text;
                    xfer.postActionData1 = @"c:\tools\fxadmin -removetransfer " + fileId;
                    admin.updateTransfer(xfer, fileId, token);
                    this.lblStatus.Text = "Transfer was added [" + fileId + "]";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
        }

        public void addInternetDownload()
        {

            w2008cc.DateTime availDate = new w2008cc.DateTime();
            availDate.year = DateTime.Now.Year;
            availDate.month = DateTime.Now.Month - 1;
            availDate.day = DateTime.Now.Day - 1;

            w2008cc.Transfer xfer = new w2008cc.Transfer();
            xfer.availableDate = availDate;
            xfer.clientFileName = "C:\\tmp\\localfile.txt";
            xfer.serverFileName = @"C:\Users\Public\FileXpress\Outgoing Customers\";
            xfer.directoryTransfer = "1"; // 0 = no 1 = yes
            xfer.description = "SOAP Added Download";
            xfer.authUserId = this.txtUser.Text;
            xfer.nodeName = "w2008cc_PS";
            xfer.sendRecvFlag = "R"; // S = upload R = download
            xfer.allowableProtocol = "SECURE";
            xfer.conversionFlag = "0"; // 0 = Ascii to EBCDIC conversion 1 = ASCII to EBCDIC conversion based on local translation table
            xfer.notifyFlag = "1";    // 0 = No. 1 = send notify email.
            xfer.notifyEmailTemplate = "email-notification-template-SOAP.xml";
            xfer.defaultNodeUserId = "administrator";
            xfer.defaultNodePwd = "password";
            xfer.defaultNTDomain = "w2008cc";
            xfer.writeMode = "Z";
            xfer.FTPAlias = "/SOAPdownload";


            try
            {
                String fileId = admin.addTransfer(xfer, token);
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
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void cmdDefine_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "" | txtPass.Text == "" | txtUser.Text == "")
            {

                MessageBox.Show(this, "User name, password and email are required.");
                return;
            }

            addInternetDownload();
            cmdDefine.Enabled = false;
            
        }

       
        ////This doesn't work
        //private void cmdKeys_Click(object sender, EventArgs e)
        //   {
        //       updateTransfer("F62120000006");

        //    //const int KeyTypeSSH = 1;
        //    //if (token == null)
        //    //{
        //    //    admin.Url = "https://w2008cc:8443/fxcc/services/AdministratorService";
        //    //    admin.Credentials = new System.Net.NetworkCredential(userID, password);

        //    //    ServicePointManager.Expect100Continue = false;
        //    //    token = admin.getSession(); 
        //    //}

        //    //w2008cc.Key sshKey = admin.getUserKey(KeyTypeSSH, "57:44:71:da:56:91:33:74:54:d9:c4:ea:62:2e:13:51", token);
        //    //w2008cc.Key sshKey = admin.getUserKey(KeyTypeSSH, "geoffp's public SSH key", token);
        //    //w2008cc.Key sshKey = admin.getUserKey(KeyTypeSSH, "geoffp", token);
        //    //String nullString = null;
        //    //w2008cc.Key[] keys = admin.retrieveAllUserServerKeys(KeyTypeSSH,"1",token);

        //    //w2008cc.Key pgpkey = admin.getSystemKey(0, "TestPGP", token);

        //    //w2008cc.Key[] keys = admin.retrieveAllPrivateKeys(0, token);
        //    //w2008cc.Key[] keys = admin.retrieveAllPrivateKeys(KeyTypeSSH, token);

        //    //String lastRecordID ="";
        //    //w2008cc.Key[] keys = admin.retrieveAllUserServerKeys(0,lastRecordID,token);


        //    //MessageBox.Show(keys[1].ToString());
        //   // MessageBox.Show(keys[0].ToString());
        //}

        private void updateTransfer(String transferID)
        {
            if (token == null)
            {
                admin.Url = "https://w2008cc:8443/fxcc/services/AdministratorService";
                admin.Credentials = new System.Net.NetworkCredential(userID, password);

                ServicePointManager.Expect100Continue = false;
                token = admin.getSession();
            }

            w2008cc.Transfer oldTransfer = admin.getTransfer(transferID, token);

            admin.removeTransfer(transferID, token);
          

            try
            {
                String fileId = admin.addTransfer(oldTransfer, token);
                oldTransfer.postActionFlag1 = "SR";
                oldTransfer.postActionType1 = "COMMAND";
                oldTransfer.postActionData1 = @"c:\tools\fxadmin -updatetransfer " + fileId;
                admin.updateTransfer(oldTransfer, fileId, token);
                this.lblStatus.Text = "Transfer was added [" + fileId + "]";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }


        }


        private void cmdBanks_Click(object sender, EventArgs e)
        {
            if (token == null)
            {
                admin.Url = "https://w2008cc:8443/fxcc/services/AdministratorService";
                admin.Credentials = new System.Net.NetworkCredential(userID, password);

                ServicePointManager.Expect100Continue = false;
                token = admin.getSession();
            }

            w2008cc.FTTransfer[] bank = admin.retrieveAllTransfersFromBank(token);
            
            listBoxBanks.Enabled = true;
            int count = 0;
            foreach (w2008cc.FTTransfer ftTransfer in bank)
            {
                if (bank[count] !=  null)
                {
                    
                    listBoxBanks.Items.Add(bank[count].description);
                    count++;

                    
                }
                listBoxBanks.Visible = true;
            }
            
            //admin.submitTransferToServer(bank[1], token);


        }

        private void listBoxBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            w2008cc.FTTransfer[] bank = admin.retrieveAllTransfersFromBank(token);
            int bankNum = listBoxBanks.SelectedIndex;
            string retval = admin.submitTransferToServer(bank[bankNum], token);
            //retval.Replace("\n", "\r\n");
            lblStatus.Text = retval;
            //lblStatus.Text = "A really long ugly message with many many many linefeeds and then more linefeeds\r\nFoobar Rules";
            listBoxBanks.Visible = false;
            
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";

            cmdCreate.Enabled = true;
            cmdDefine.Enabled = true;

            lblStatus.Text = "";
            listBoxBanks.Items.Clear();
            listBoxBanks.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
