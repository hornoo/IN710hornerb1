using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_practical
{
    public partial class Form1 : Form
    {
        // Set text pasing worker
        TextParser textParser;

        public Form1()
        {
            InitializeComponent();

            //Initilise text parsing worker
            textParser = new TextParser();
        }

        private void ButEncrypt_Click(object sender, EventArgs e)
        {   //Run method
            encryptText();
        }

        private void ButDecrypt_Click(object sender, EventArgs e)
        {
            encryptText();
        }

        public void encryptText()
        {
            //Check whick radio button is selected, passin correct encryption machine, run encryption method on input string and pass output to text box.
            String inputString = tbInPut.Text;

            if (rdRot13.Checked)
            {
                textParser.encryptionmachine = new ROT13Encryt();
            }
            else
            {
                textParser.encryptionmachine = new ReverseEncrption();
            }

            tbOutput.Text = textParser.EncryptDecrypt(inputString);
        }
    }
}
