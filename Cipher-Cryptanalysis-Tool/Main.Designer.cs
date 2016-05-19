namespace CipherCryptanalysisTool
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.btn_fSave = new System.Windows.Forms.Button();
            this.Btn_fOpen = new System.Windows.Forms.Button();
            this.radioBtn_Plain = new System.Windows.Forms.RadioButton();
            this.radioBtn_Cipher = new System.Windows.Forms.RadioButton();
            this.text_Cipher = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.text_Plain = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_CipherKey = new System.Windows.Forms.TextBox();
            this.text_CipherKey2 = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fSave
            // 
            this.btn_fSave.Location = new System.Drawing.Point(682, 11);
            this.btn_fSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_fSave.Name = "btn_fSave";
            this.btn_fSave.Size = new System.Drawing.Size(80, 25);
            this.btn_fSave.TabIndex = 11;
            this.btn_fSave.Text = "파일 저장";
            this.btn_fSave.UseVisualStyleBackColor = true;
            this.btn_fSave.Click += new System.EventHandler(this.btn_fSave_Click);
            // 
            // Btn_fOpen
            // 
            this.Btn_fOpen.Location = new System.Drawing.Point(596, 11);
            this.Btn_fOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_fOpen.Name = "Btn_fOpen";
            this.Btn_fOpen.Size = new System.Drawing.Size(80, 25);
            this.Btn_fOpen.TabIndex = 9;
            this.Btn_fOpen.Text = "파일 열기";
            this.Btn_fOpen.UseVisualStyleBackColor = true;
            this.Btn_fOpen.Click += new System.EventHandler(this.Btn_fOpen_Click);
            // 
            // radioBtn_Plain
            // 
            this.radioBtn_Plain.AutoSize = true;
            this.radioBtn_Plain.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_Plain.Checked = true;
            this.radioBtn_Plain.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioBtn_Plain.ForeColor = System.Drawing.Color.White;
            this.radioBtn_Plain.Location = new System.Drawing.Point(535, 13);
            this.radioBtn_Plain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_Plain.Name = "radioBtn_Plain";
            this.radioBtn_Plain.Size = new System.Drawing.Size(65, 21);
            this.radioBtn_Plain.TabIndex = 13;
            this.radioBtn_Plain.TabStop = true;
            this.radioBtn_Plain.Text = "평문";
            this.radioBtn_Plain.UseVisualStyleBackColor = false;
            // 
            // radioBtn_Cipher
            // 
            this.radioBtn_Cipher.AutoSize = true;
            this.radioBtn_Cipher.BackColor = System.Drawing.Color.Transparent;
            this.radioBtn_Cipher.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioBtn_Cipher.ForeColor = System.Drawing.Color.White;
            this.radioBtn_Cipher.Location = new System.Drawing.Point(456, 13);
            this.radioBtn_Cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtn_Cipher.Name = "radioBtn_Cipher";
            this.radioBtn_Cipher.Size = new System.Drawing.Size(83, 21);
            this.radioBtn_Cipher.TabIndex = 12;
            this.radioBtn_Cipher.TabStop = true;
            this.radioBtn_Cipher.Text = "암호문";
            this.radioBtn_Cipher.UseVisualStyleBackColor = false;
            // 
            // text_Cipher
            // 
            this.text_Cipher.BackColor = System.Drawing.SystemColors.Window;
            this.text_Cipher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Cipher.Location = new System.Drawing.Point(2, 2);
            this.text_Cipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Cipher.Multiline = true;
            this.text_Cipher.Name = "text_Cipher";
            this.text_Cipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Cipher.Size = new System.Drawing.Size(735, 415);
            this.text_Cipher.TabIndex = 11;
            // 
            // ofd
            // 
            this.ofd.Filter = "Text files | *.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Text files | *.txt";
            // 
            // text_Plain
            // 
            this.text_Plain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Plain.Location = new System.Drawing.Point(2, 2);
            this.text_Plain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Plain.Multiline = true;
            this.text_Plain.Name = "text_Plain";
            this.text_Plain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_Plain.Size = new System.Drawing.Size(735, 415);
            this.text_Plain.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "KEY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(295, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "~";
            // 
            // text_CipherKey
            // 
            this.text_CipherKey.Location = new System.Drawing.Point(235, 11);
            this.text_CipherKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_CipherKey.Name = "text_CipherKey";
            this.text_CipherKey.Size = new System.Drawing.Size(57, 25);
            this.text_CipherKey.TabIndex = 5;
            this.text_CipherKey.TextChanged += new System.EventHandler(this.text_CipherKey_TextChanged);
            // 
            // text_CipherKey2
            // 
            this.text_CipherKey2.Location = new System.Drawing.Point(322, 11);
            this.text_CipherKey2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_CipherKey2.Name = "text_CipherKey2";
            this.text_CipherKey2.Size = new System.Drawing.Size(57, 25);
            this.text_CipherKey2.TabIndex = 6;
            this.text_CipherKey2.TextChanged += new System.EventHandler(this.text_CipherKey2_TextChanged);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(98, 494);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(80, 25);
            this.btn_Decrypt.TabIndex = 14;
            this.btn_Decrypt.Text = "복호화";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(12, 494);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(80, 25);
            this.btn_Encrypt.TabIndex = 15;
            this.btn_Encrypt.Text = "암호화";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.text_Plain);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 421);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "PlainText";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 450);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.text_Cipher);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 421);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "CipherText";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(678, 494);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(80, 25);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "종료";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(471, 496);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Show Middle Process";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CipherCryptanalysisTool.Properties.Resources.MainBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 528);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_fSave);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.Btn_fOpen);
            this.Controls.Add(this.radioBtn_Plain);
            this.Controls.Add(this.text_CipherKey2);
            this.Controls.Add(this.radioBtn_Cipher);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.text_CipherKey);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "암호화/복호화 툴";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtn_Plain;
        private System.Windows.Forms.RadioButton radioBtn_Cipher;
        private System.Windows.Forms.Button btn_fSave;
        private System.Windows.Forms.Button Btn_fOpen;
        private System.Windows.Forms.TextBox text_Cipher;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox text_Plain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_CipherKey;
        private System.Windows.Forms.TextBox text_CipherKey2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

