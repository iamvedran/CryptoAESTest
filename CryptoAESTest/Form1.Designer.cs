namespace CryptoAESTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.encrypt = new System.Windows.Forms.TabPage();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.TabPage();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxPlain2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEncrypted2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.encrypt.SuspendLayout();
            this.decrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.encrypt);
            this.tabControl1.Controls.Add(this.decrypt);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // encrypt
            // 
            this.encrypt.Controls.Add(this.buttonEncrypt);
            this.encrypt.Controls.Add(this.encryptedTextBox);
            this.encrypt.Controls.Add(this.label3);
            this.encrypt.Controls.Add(this.label2);
            this.encrypt.Controls.Add(this.plainTextBox);
            this.encrypt.Controls.Add(this.label1);
            this.encrypt.Controls.Add(this.passwordBox);
            this.encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encrypt.Location = new System.Drawing.Point(4, 29);
            this.encrypt.Name = "encrypt";
            this.encrypt.Padding = new System.Windows.Forms.Padding(3);
            this.encrypt.Size = new System.Drawing.Size(690, 524);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Kriptiranje";
            this.encrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEncrypt.Location = new System.Drawing.Point(545, 48);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(121, 36);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Kriptiraj!";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.encryptedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptedTextBox.Location = new System.Drawing.Point(22, 304);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTextBox.Size = new System.Drawing.Size(644, 214);
            this.encryptedTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(18, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kriptirano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izvorni tekst:";
            // 
            // plainTextBox
            // 
            this.plainTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.plainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plainTextBox.Location = new System.Drawing.Point(22, 125);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plainTextBox.Size = new System.Drawing.Size(644, 129);
            this.plainTextBox.TabIndex = 2;
            this.plainTextBox.Text = resources.GetString("plainTextBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lozinka:";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordBox.Location = new System.Drawing.Point(22, 48);
            this.passwordBox.MaxLength = 16;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(168, 26);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.Text = "TestPassw0rd+123";
            // 
            // decrypt
            // 
            this.decrypt.Controls.Add(this.buttonDecrypt);
            this.decrypt.Controls.Add(this.textBoxPlain2);
            this.decrypt.Controls.Add(this.label4);
            this.decrypt.Controls.Add(this.label5);
            this.decrypt.Controls.Add(this.textBoxEncrypted2);
            this.decrypt.Controls.Add(this.label6);
            this.decrypt.Controls.Add(this.textBoxPassword2);
            this.decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decrypt.Location = new System.Drawing.Point(4, 29);
            this.decrypt.Name = "decrypt";
            this.decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.decrypt.Size = new System.Drawing.Size(690, 524);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Dekriptiranje";
            this.decrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDecrypt.Location = new System.Drawing.Point(553, 48);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(113, 36);
            this.buttonDecrypt.TabIndex = 13;
            this.buttonDecrypt.Text = "Dekriptiraj!";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxPlain2
            // 
            this.textBoxPlain2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPlain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPlain2.Location = new System.Drawing.Point(22, 304);
            this.textBoxPlain2.Multiline = true;
            this.textBoxPlain2.Name = "textBoxPlain2";
            this.textBoxPlain2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlain2.Size = new System.Drawing.Size(644, 214);
            this.textBoxPlain2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kriptirano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(18, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izvorni tekst:";
            // 
            // textBoxEncrypted2
            // 
            this.textBoxEncrypted2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEncrypted2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEncrypted2.Location = new System.Drawing.Point(22, 125);
            this.textBoxEncrypted2.Multiline = true;
            this.textBoxEncrypted2.Name = "textBoxEncrypted2";
            this.textBoxEncrypted2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncrypted2.Size = new System.Drawing.Size(644, 129);
            this.textBoxEncrypted2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lozinka:";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword2.Location = new System.Drawing.Point(22, 48);
            this.textBoxPassword2.MaxLength = 16;
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(168, 26);
            this.textBoxPassword2.TabIndex = 7;
            this.textBoxPassword2.Text = "TestPassw0rd+123";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES Test";
            this.tabControl1.ResumeLayout(false);
            this.encrypt.ResumeLayout(false);
            this.encrypt.PerformLayout();
            this.decrypt.ResumeLayout(false);
            this.decrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage encrypt;
        private System.Windows.Forms.TabPage decrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxPlain2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncrypted2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword2;
    }
}

