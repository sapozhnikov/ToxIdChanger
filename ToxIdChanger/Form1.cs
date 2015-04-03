using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography;

namespace ToxIdChanger
{
    public partial class Form1 : Form
    {
        const int OFFSET_NOSPAM = 0x10;
        const int OFFSET_PUBKEY = 0x14;
        const int OFFSET_PRVKEY = 0x14 + 32;

        byte[] fileContent;

        public Form1()
        {
            InitializeComponent();
        }

        private void butBrowseFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "tox_save.tox|tox_save.tox|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textFilePath.Text = fileDialog.FileName;
                ParseFile(fileDialog.FileName);
                UpdatePublicKey();
            }
        }

        void ParseFile(string fileName)
        {
            fileContent = File.ReadAllBytes(fileName);

            textNoSpam.Text = Utils.BinToString(fileContent, OFFSET_NOSPAM, 4);
            textPublicKey.Text = Utils.BinToString(fileContent, OFFSET_PUBKEY, 32);
            textPrivateKey.Text = Utils.BinToString(fileContent, OFFSET_PRVKEY, 32);
        }

        byte[] pubKey;
        byte[] prvKey;
        byte[] noSpam;

        private void butSave_Click(object sender, EventArgs e)
        {
            //checks
            if (fileContent.Length <= 0)
            {
                MessageBox.Show("No file loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((textPublicKey.Text.Length != 64) || !Regex.IsMatch(textPublicKey.Text, "^[0-9a-fA-F]+$"))
            {
                MessageBox.Show("Wrong public key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((textPrivateKey.Text.Length != 64) || !Regex.IsMatch(textPrivateKey.Text, "^[0-9a-fA-F]+$"))
            {
                MessageBox.Show("Wrong private key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((textNoSpam.Text.Length != 8) || !Regex.IsMatch(textNoSpam.Text, "^[0-9a-fA-F]+$"))
            {
                MessageBox.Show("Wrong NoSpam value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ParseTextFields();

            for (int i = 0; i < 32; i++)
                fileContent[OFFSET_PUBKEY + i] = pubKey[i];

            for (int i = 0; i < 32; i++)
                fileContent[OFFSET_PRVKEY + i] = prvKey[i];
            
            for (int i = 0; i < 4; i++)
                fileContent[OFFSET_NOSPAM + i] = noSpam[i];

            //saving file
            if (File.Exists(textFilePath.Text))
            {
                string initialFile, backupFile;
                initialFile = textFilePath.Text;
                backupFile = textFilePath.Text + ".bak";
                File.Move(initialFile, backupFile);
                File.WriteAllBytes(initialFile, fileContent);
                File.Delete(backupFile);
            }
            else
                File.WriteAllBytes(textFilePath.Text, fileContent);
        }

        void ParseTextFields()
        {
            //updating data
            pubKey = Utils.StringToBin(textPublicKey.Text);
            prvKey = Utils.StringToBin(textPrivateKey.Text);
            noSpam = Utils.StringToBin(textNoSpam.Text);
        }

        void UpdatePublicKey()
        {
            if (((textPublicKey.Text.Length != 64) || !Regex.IsMatch(textPublicKey.Text, "^[0-9a-fA-F]+$")) ||
                ((textPrivateKey.Text.Length != 64) || !Regex.IsMatch(textPrivateKey.Text, "^[0-9a-fA-F]+$")) ||
                ((textNoSpam.Text.Length != 8) || !Regex.IsMatch(textNoSpam.Text, "^[0-9a-fA-F]+$")))
            {
                textPublicAddr.Text = "-";
                return;
            }
            
            ParseTextFields();

            byte[] checksum = { 0, 0 };
            for (int i = 0; i < 32; i++)
                checksum[i % 2] ^= pubKey[i];
            for (int i = 0; i < 4; i++)
                checksum[i % 2] ^= noSpam[i];

            string friendsAddr = textPublicKey.Text + textNoSpam.Text + Utils.BinToString(checksum, 0, 2);
            textPublicAddr.Text = friendsAddr.ToUpper();
        }

        private void textPublicKey_TextChanged(object sender, EventArgs e)
        {
            UpdatePublicKey();
        }

        private void textPrivateKey_TextChanged(object sender, EventArgs e)
        {
            UpdatePublicKey();
        }

        private void textNoSpam_TextChanged(object sender, EventArgs e)
        {
            UpdatePublicKey();
        }

        private void butSetRandom_Click(object sender, EventArgs e)
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] rndContainer = new byte[4];
            rngCsp.GetBytes(rndContainer);

            textNoSpam.Text = Utils.BinToString(rndContainer, 0, 4);
            UpdatePublicKey();
        }
    }
}
