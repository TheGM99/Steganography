
namespace Steganography
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
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.CipherImg = new System.Windows.Forms.PictureBox();
            this.CipherButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DecryptedMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.OpenFileCipher = new System.Windows.Forms.Button();
            this.DecipherPathbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OpenFileDecipher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CipherImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearImg
            // 
            this.ClearImg.Location = new System.Drawing.Point(91, 29);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(250, 250);
            this.ClearImg.TabIndex = 0;
            this.ClearImg.TabStop = false;
            // 
            // CipherImg
            // 
            this.CipherImg.Location = new System.Drawing.Point(466, 29);
            this.CipherImg.Name = "CipherImg";
            this.CipherImg.Size = new System.Drawing.Size(250, 250);
            this.CipherImg.TabIndex = 1;
            this.CipherImg.TabStop = false;
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(22, 405);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(202, 33);
            this.CipherButton.TabIndex = 2;
            this.CipherButton.Text = "Cipher";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(159, 299);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(240, 22);
            this.pathBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text after Deciphering :";
            // 
            // DecryptedMsg
            // 
            this.DecryptedMsg.AutoSize = true;
            this.DecryptedMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptedMsg.Location = new System.Drawing.Point(485, 331);
            this.DecryptedMsg.Name = "DecryptedMsg";
            this.DecryptedMsg.Size = new System.Drawing.Size(0, 20);
            this.DecryptedMsg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image Path (Cipher)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text to Cipher";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(159, 331);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(283, 22);
            this.textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clean Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Image with ciphered text";
            // 
            // DecipherButton
            // 
            this.DecipherButton.Location = new System.Drawing.Point(259, 405);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(183, 33);
            this.DecipherButton.TabIndex = 11;
            this.DecipherButton.Text = "Decipher";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // OpenFileCipher
            // 
            this.OpenFileCipher.Location = new System.Drawing.Point(405, 298);
            this.OpenFileCipher.Name = "OpenFileCipher";
            this.OpenFileCipher.Size = new System.Drawing.Size(37, 23);
            this.OpenFileCipher.TabIndex = 12;
            this.OpenFileCipher.Text = "...";
            this.OpenFileCipher.UseVisualStyleBackColor = true;
            this.OpenFileCipher.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // DecipherPathbox
            // 
            this.DecipherPathbox.Location = new System.Drawing.Point(159, 365);
            this.DecipherPathbox.Name = "DecipherPathbox";
            this.DecipherPathbox.Size = new System.Drawing.Size(240, 22);
            this.DecipherPathbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Image Path (Decipher)";
            // 
            // OpenFileDecipher
            // 
            this.OpenFileDecipher.Location = new System.Drawing.Point(405, 365);
            this.OpenFileDecipher.Name = "OpenFileDecipher";
            this.OpenFileDecipher.Size = new System.Drawing.Size(37, 23);
            this.OpenFileDecipher.TabIndex = 15;
            this.OpenFileDecipher.Text = "...";
            this.OpenFileDecipher.UseVisualStyleBackColor = true;
            this.OpenFileDecipher.Click += new System.EventHandler(this.OpenFileDecipher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenFileDecipher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DecipherPathbox);
            this.Controls.Add(this.OpenFileCipher);
            this.Controls.Add(this.DecipherButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DecryptedMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.CipherImg);
            this.Controls.Add(this.ClearImg);
            this.Name = "Form1";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CipherImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ClearImg;
        private System.Windows.Forms.PictureBox CipherImg;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DecryptedMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.Button OpenFileCipher;
        private System.Windows.Forms.TextBox DecipherPathbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OpenFileDecipher;
    }
}

