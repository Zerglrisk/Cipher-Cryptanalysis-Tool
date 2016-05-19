namespace monoalphabetic_cipher_cryptanalysis
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Plain = new System.Windows.Forms.RadioButton();
            this.radioBtn_Cipher = new System.Windows.Forms.RadioButton();
            this.btn_fSave = new System.Windows.Forms.Button();
            this.text_fPath = new System.Windows.Forms.TextBox();
            this.Btn_fOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.text_Cipher = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Plain = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_CipherKey2 = new System.Windows.Forms.TextBox();
            this.text_CipherKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_Plain);
            this.groupBox1.Controls.Add(this.radioBtn_Cipher);
            this.groupBox1.Controls.Add(this.btn_fSave);
            this.groupBox1.Controls.Add(this.text_fPath);
            this.groupBox1.Controls.Add(this.Btn_fOpen);
            this.groupBox1.Location = new System.Drawing.Point(378, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioBtn_Plain
            // 
            this.radioBtn_Plain.AutoSize = true;
            this.radioBtn_Plain.Location = new System.Drawing.Point(77, 46);
            this.radioBtn_Plain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_Plain.Name = "radioBtn_Plain";
            this.radioBtn_Plain.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_Plain.TabIndex = 13;
            this.radioBtn_Plain.TabStop = true;
            this.radioBtn_Plain.Text = "평문";
            this.radioBtn_Plain.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Cipher
            // 
            this.radioBtn_Cipher.AutoSize = true;
            this.radioBtn_Cipher.Location = new System.Drawing.Point(5, 46);
            this.radioBtn_Cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_Cipher.Name = "radioBtn_Cipher";
            this.radioBtn_Cipher.Size = new System.Drawing.Size(59, 16);
            this.radioBtn_Cipher.TabIndex = 12;
            this.radioBtn_Cipher.TabStop = true;
            this.radioBtn_Cipher.Text = "암호문";
            this.radioBtn_Cipher.UseVisualStyleBackColor = true;
            // 
            // btn_fSave
            // 
            this.btn_fSave.Location = new System.Drawing.Point(220, 44);
            this.btn_fSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fSave.Name = "btn_fSave";
            this.btn_fSave.Size = new System.Drawing.Size(70, 20);
            this.btn_fSave.TabIndex = 11;
            this.btn_fSave.Text = "저장";
            this.btn_fSave.UseVisualStyleBackColor = true;
            this.btn_fSave.Click += new System.EventHandler(this.btn_fSave_Click);
            // 
            // text_fPath
            // 
            this.text_fPath.Location = new System.Drawing.Point(5, 19);
            this.text_fPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_fPath.Name = "text_fPath";
            this.text_fPath.Size = new System.Drawing.Size(286, 21);
            this.text_fPath.TabIndex = 10;
            // 
            // Btn_fOpen
            // 
            this.Btn_fOpen.Location = new System.Drawing.Point(146, 44);
            this.Btn_fOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_fOpen.Name = "Btn_fOpen";
            this.Btn_fOpen.Size = new System.Drawing.Size(70, 20);
            this.Btn_fOpen.TabIndex = 9;
            this.Btn_fOpen.Text = "열기";
            this.Btn_fOpen.UseVisualStyleBackColor = true;
            this.Btn_fOpen.Click += new System.EventHandler(this.Btn_fOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Encrypt);
            this.groupBox2.Controls.Add(this.text_Cipher);
            this.groupBox2.Controls.Add(this.btn_Decrypt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_Plain);
            this.groupBox2.Location = new System.Drawing.Point(10, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(663, 344);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(297, 186);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(70, 20);
            this.btn_Encrypt.TabIndex = 15;
            this.btn_Encrypt.Text = "<<암호화";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // text_Cipher
            // 
            this.text_Cipher.BackColor = System.Drawing.SystemColors.Window;
            this.text_Cipher.Location = new System.Drawing.Point(1, 23);
            this.text_Cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Cipher.Multiline = true;
            this.text_Cipher.Name = "text_Cipher";
            this.text_Cipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Cipher.Size = new System.Drawing.Size(295, 321);
            this.text_Cipher.TabIndex = 11;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(297, 142);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(70, 20);
            this.btn_Decrypt.TabIndex = 14;
            this.btn_Decrypt.Text = "복호화>>";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "암호문";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "평문";
            // 
            // text_Plain
            // 
            this.text_Plain.Location = new System.Drawing.Point(368, 23);
            this.text_Plain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Plain.Multiline = true;
            this.text_Plain.Name = "text_Plain";
            this.text_Plain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Plain.Size = new System.Drawing.Size(295, 321);
            this.text_Plain.TabIndex = 12;
            // 
            // ofd
            // 
            this.ofd.Filter = "Text files | *.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Text files | *.txt";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.text_CipherKey2);
            this.groupBox3.Controls.Add(this.text_CipherKey);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(362, 80);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // text_CipherKey2
            // 
            this.text_CipherKey2.Location = new System.Drawing.Point(273, 18);
            this.text_CipherKey2.Name = "text_CipherKey2";
            this.text_CipherKey2.Size = new System.Drawing.Size(50, 21);
            this.text_CipherKey2.TabIndex = 6;
            this.text_CipherKey2.TextChanged += new System.EventHandler(this.text_CipherKey2_TextChanged);
            // 
            // text_CipherKey
            // 
            this.text_CipherKey.Location = new System.Drawing.Point(197, 18);
            this.text_CipherKey.Name = "text_CipherKey";
            this.text_CipherKey.Size = new System.Drawing.Size(50, 21);
            this.text_CipherKey.TabIndex = 5;
            this.text_CipherKey.TextChanged += new System.EventHandler(this.text_CipherKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "KEY";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(6, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.RadioButton radioBtn_Plain;
        private System.Windows.Forms.RadioButton radioBtn_Cipher;
        private System.Windows.Forms.Button btn_fSave;
        private System.Windows.Forms.TextBox text_fPath;
        private System.Windows.Forms.Button Btn_fOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox text_Cipher;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Plain;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_CipherKey;
        private System.Windows.Forms.TextBox text_CipherKey2;
    }
}

