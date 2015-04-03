namespace ToxIdChanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butBrowseFile = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNoSpam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrivateKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textPublicAddr = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butSetRandom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butBrowseFile);
            this.groupBox1.Controls.Add(this.textFilePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tox_save.tox file location";
            // 
            // butBrowseFile
            // 
            this.butBrowseFile.Location = new System.Drawing.Point(515, 19);
            this.butBrowseFile.Name = "butBrowseFile";
            this.butBrowseFile.Size = new System.Drawing.Size(38, 23);
            this.butBrowseFile.TabIndex = 1;
            this.butBrowseFile.Text = "...";
            this.butBrowseFile.UseVisualStyleBackColor = true;
            this.butBrowseFile.Click += new System.EventHandler(this.butBrowseFile_Click_1);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(7, 20);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(502, 20);
            this.textFilePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butSetRandom);
            this.groupBox2.Controls.Add(this.textNoSpam);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textPrivateKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textPublicKey);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // textNoSpam
            // 
            this.textNoSpam.Location = new System.Drawing.Point(7, 125);
            this.textNoSpam.Name = "textNoSpam";
            this.textNoSpam.Size = new System.Drawing.Size(71, 20);
            this.textNoSpam.TabIndex = 5;
            this.textNoSpam.TextChanged += new System.EventHandler(this.textNoSpam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NoSpam";
            // 
            // textPrivateKey
            // 
            this.textPrivateKey.Location = new System.Drawing.Point(7, 81);
            this.textPrivateKey.Name = "textPrivateKey";
            this.textPrivateKey.Size = new System.Drawing.Size(546, 20);
            this.textPrivateKey.TabIndex = 3;
            this.textPrivateKey.TextChanged += new System.EventHandler(this.textPrivateKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Private";
            // 
            // textPublicKey
            // 
            this.textPublicKey.Location = new System.Drawing.Point(7, 37);
            this.textPublicKey.Name = "textPublicKey";
            this.textPublicKey.Size = new System.Drawing.Size(546, 20);
            this.textPublicKey.TabIndex = 1;
            this.textPublicKey.TextChanged += new System.EventHandler(this.textPublicKey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textPublicAddr);
            this.groupBox3.Location = new System.Drawing.Point(13, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Public address";
            // 
            // textPublicAddr
            // 
            this.textPublicAddr.Location = new System.Drawing.Point(7, 20);
            this.textPublicAddr.Name = "textPublicAddr";
            this.textPublicAddr.ReadOnly = true;
            this.textPublicAddr.Size = new System.Drawing.Size(546, 20);
            this.textPublicAddr.TabIndex = 0;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(496, 305);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 27);
            this.butSave.TabIndex = 3;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butSetRandom
            // 
            this.butSetRandom.Location = new System.Drawing.Point(85, 124);
            this.butSetRandom.Name = "butSetRandom";
            this.butSetRandom.Size = new System.Drawing.Size(58, 23);
            this.butSetRandom.TabIndex = 6;
            this.butSetRandom.Text = "Random";
            this.butSetRandom.UseVisualStyleBackColor = true;
            this.butSetRandom.Click += new System.EventHandler(this.butSetRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 344);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOX ID Editor (for uTox 0.2.o)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butBrowseFile;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textNoSpam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textPublicAddr;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butSetRandom;
    }
}

