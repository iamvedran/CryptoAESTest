using AESEncrtyption;
using System;
using System.Windows.Forms;

namespace CryptoAESTest
{
    public partial class Form1 : Form
    {
        System.Text.RegularExpressions.Regex myRegex = new System.Text.RegularExpressions.Regex("^[a-fA-F0-9]+$");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length < 16)
            {
                MessageBox.Show("Lozinka mora imati 16 znakova!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (plainTextBox.Text.Length < 1)
            {
                MessageBox.Show("Nema teksta za kriptiranje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string plainText = plainTextBox.Text;
            string password = passwordBox.Text;

            string encryptedText = AES.Encrypt(plainText, password);

            encryptedTextBox.Text = encryptedText;
        }


        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword2.Text.Length < 16)
            {
                MessageBox.Show("Lozinka mora imati 16 znakova!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (textBoxEncrypted2.Text.Length < 1)
            {
                MessageBox.Show("Nema teksta za dekriptiranje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string encryptedText = textBoxEncrypted2.Text;
            string password = textBoxPassword2.Text;

            // provjera hex formata
            if (!IsHeX(encryptedText)) { return; }

            string decryptedText = AES.Decrypt(encryptedText, password);

            textBoxPlain2.Text = decryptedText;
        }

        private bool IsHeX(string encryptedText)
        {
            bool isHex = myRegex.IsMatch(encryptedText);
            if (!isHex)
            {
                MessageBox.Show("Nije heksadecimalni format!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
