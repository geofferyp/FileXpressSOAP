//  FileXpressSOAP is a demonstration that can be executed without an internet connection on a System with FileXPress
//  demonstration virtual machines installed. It can be used on any working FileXpress system that includes an Internet Server, 
//  Command Center and Platform server. The Web reference to FXCC would need to be deleted and replaced with a New FXCC
//  web referencee that points to the WSDL on your Command Center. Names of file transfer definitions will also need to be 
//  changed to match your system.
//
//  ***Scenario 1*** for this demonstration is to act in the role of an operations person who can quickly create a user, 
//  and then assign that user access to the pre-defined FileXpress Internet server transfers. You can then demonstrate the 
//  the user receiving an email and clicking a link to access a client to download or upload files.
//
//  *** Scenario 2 *** accessed by clicking More... button is meant to demonstrate the ability to automate Platform Server transfers through the SOAP interface.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileXpressSOAP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new SOAPDemo());
        }
    }
}
