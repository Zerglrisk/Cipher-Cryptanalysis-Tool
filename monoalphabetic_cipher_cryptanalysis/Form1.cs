using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monoalphabetic_cipher_cryptanalysis
{

    public partial class Form1 : Form
    {
        int minLimitNumber = 0;
        int maxLimitNumber = 0;
        public Form1()
        {
            InitializeComponent();

            //Custom Init
            radioBtn_Cipher.Select();
            comboBox1.Items.Add("Additive Cipher");
            comboBox1.Items.Add("Multiplicative Cipher");
            comboBox1.SelectedIndex = 0;
            minLimitNumber = 0;
            maxLimitNumber = 25;
        }

        private void Btn_fOpen_Click(object sender, EventArgs e)
        {
            //reference : http://www.howtosolutions.net/2012/05/winform-open-file-browser-dialog-examples/
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                text_fPath.Text = ofd.FileName;
                if (radioBtn_Cipher.Checked)
                {
                    text_Cipher.Text = File.ReadAllText(ofd.FileName);
                }
                else if (radioBtn_Plain.Checked)
                {
                    text_Plain.Text = File.ReadAllText(ofd.FileName);
                }
            }
        }

        private void btn_fSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                text_fPath.Text = sfd.FileName;
                if (radioBtn_Cipher.Checked)
                {
                    File.WriteAllText(sfd.FileName, text_Cipher.Text);
                }
                else if (radioBtn_Plain.Checked)
                {
                    File.WriteAllText(sfd.FileName, text_Plain.Text);
                }
            }

        }
        private void text_CipherKey_TextChanged(object sender, EventArgs e)
        {
            int val = 0;
            bool res = Int32.TryParse(((TextBox)sender).Text, out val);

            if (res && val < minLimitNumber)
                text_CipherKey.Text = minLimitNumber.ToString();
            else if (res && val > maxLimitNumber)
                text_CipherKey.Text = maxLimitNumber.ToString();

            text_CipherKey2.Text = text_CipherKey.Text;
        }

        private void text_CipherKey2_TextChanged(object sender, EventArgs e)
        {
            int val = 0;
            bool res = Int32.TryParse(((TextBox)sender).Text, out val);
            if (res && val < minLimitNumber)
                text_CipherKey2.Text = minLimitNumber.ToString();
            else if (res && val > maxLimitNumber)
                text_CipherKey2.Text = maxLimitNumber.ToString();
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string decrypt = "";
            char[] array;

            int val = 0;
            bool res = Int32.TryParse(text_CipherKey.Text, out val);
            int val2 = 0;
            bool res2 = Int32.TryParse(text_CipherKey2.Text, out val2);

            if (res && res2 && val > val2)
            {
                string temp;
                temp = text_CipherKey.Text;
                text_CipherKey.Text = text_CipherKey2.Text;
                text_CipherKey2.Text = temp;
            }

            if (text_Cipher.Text == "")
            {
                MessageBox.Show("복호화할 문자열이 없습니다.");
                return;
            }
                
            else
                array = text_Cipher.Text.ToLower().ToCharArray();

            switch (comboBox1.SelectedIndex)
            {
                case 0: //Additive Cipher
                    for (int i = val; i <= val2; i++)
                    {
                        decrypt += "Key : " + i.ToString() + "'s Decrypt\r\n";
                        for (int j = 0; j < array.Length; j++)
                        {
                            int num = (int)array[j];
                            if (num == 'a')
                                num = 'h';
                            else if (num == 'A')
                                num = 'H';
                            else if (num == 'i')
                                num = 'i';
                            else if (num == 'I')
                                num = 'I';
                            else if (num == 'r')
                                num = 'r';
                            else if (num == 'R')
                                num = 'R';
                            else if (num == 'j')
                                num = 'q';
                            else if (num == 'J')
                                num = 'Q';
                            else if (num >= 'a' && num <= 'z')
                            {
                                num -= i;
                                if (num > 'z')
                                    num = num - 26;

                                if (num < 'a')
                                    num = num + 26;

                            }
                            else if (num >= 'A' && num <= 'Z')
                            {
                                num -= i;
                                if (num > 'Z')
                                    num = num - 26;

                                if (num < 'A')
                                    num = num + 26;

                            }
                            decrypt += ((char)num).ToString();
                        }
                        decrypt += "\r\n\r\n";
                    }
                    text_Plain.Text = decrypt.ToLower();
                    break;
                case 1: //Multiplicative Cipher
                    for (int i = val; i <= val2; i++)
                    {
                        decrypt += "Key : " + i.ToString() + "'s Decrypt\r\n";
                        int key;
                        if((key = FindGCDRelativePrime(26, i)) == -1)
                        {
                            decrypt += "Key의 역원이 없음.\r\n\r\n";
                            continue;
                        }
                        for (int j = 0; j < array.Length; j++)
                        {
                            int num = (int)array[j];
                            
                            if (num >= 'a' && num <= 'z')
                            {
                                num -= 'a';
                                num *= key;
                                num %= 26;
                                num += 'a';
                            }
                            else if (num >= 'A' && num <= 'Z')
                            {
                                num -= 'A';
                                num *= key;
                                num %= 26;
                                num += 'A';
                            }
                            
                            decrypt += ((char)num).ToString();
                        }
                        decrypt += "\r\n\r\n";
                    }
                    text_Plain.Text = decrypt.ToLower();
                    break;
                default:
                    break;
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string encrypt = "";
            char[] array;
            int val;
            bool res = Int32.TryParse(text_CipherKey.Text, out val);
            int val2;
            bool res2 = Int32.TryParse(text_CipherKey2.Text, out val2);


            if (res && res2 && val > val2)
            {
                string temp;
                temp = text_CipherKey.Text;
                text_CipherKey.Text = text_CipherKey2.Text;
                text_CipherKey2.Text = temp;
            }
            text_Cipher.Text = null;

            if (text_Plain.Text == "")
            {
                MessageBox.Show("암호화할 문자열이 없습니다.");
                return;
            }
                
            else
                array = text_Plain.Text.ToLower().ToCharArray();

            switch (comboBox1.SelectedIndex)
            {
                case 0: //Additive Cipher

                    for (int i = val; i <= val2; i++)
                    {
                        encrypt += "Key : " + i.ToString() + "'s Encrypt\r\n";
                        for (int j = 0; j < array.Length; j++)
                        {
                            int num = (int)array[j];
                            if (num == 'h')
                                num = 'a';
                            else if (num == 'H')
                                num = 'a';
                            else if (num == 'i')
                                num = 'i';
                            else if (num == 'I')
                                num = 'I';
                            else if (num == 'r')
                                num = 'r';
                            else if (num == 'R')
                                num = 'R';
                            else if (num == 'q')
                                num = 'j';
                            else if (num == 'Q')
                                num = 'J';
                            else if (num >= 'a' && num <= 'z')
                            {
                                num += i;
                                if (num > 'z')
                                    num = num - 26;

                                if (num < 'a')
                                    num = num + 26;

                            }
                            else if (num >= 'A' && num <= 'Z')
                            {
                                num += i;
                                if (num > 'Z')
                                    num = num - 26;

                                if (num < 'A')
                                    num = num + 26;

                            }
                            encrypt += ((char)num).ToString();
                        }
                        encrypt += "\r\n\r\n";

                    }
                    text_Cipher.Text = encrypt.ToUpper();
                    break;
                case 1: //Multiplicative Cipher
                    for (int i = val; i <= val2; i++)
                    {
                        encrypt += "Key : " + i.ToString() + "'s Encrypt\r\n";
                        for (int j = 0; j < array.Length; j++)
                        {
                            int num = (int)array[j];
                            if (num >= 'a' && num <= 'z')
                            {
                                num -= 'a';
                                num *= i;
                                num %= 26;
                                num += 'a';
                            }
                            else if (num >= 'A' && num <= 'Z')
                            {
                                num -= 'A';
                                num *= i;
                                num %= 26;
                                num += 'A';
                            }
                            encrypt += ((char)num).ToString();
                        }
                        encrypt += "\r\n\r\n";
                    }
                    text_Cipher.Text = encrypt.ToLower();
                    break;
                default:
                    break;
            }
        }

        private int FindGCDRelativePrime(int r1, int r2)
        {
            r1 = Math.Abs(r1);
            r2 = Math.Abs(r2);
            int t1 = 0, t2= 1 ;

            // Pull out remainders.
            for (;;)
            {
                int remainder = r1 % r2;
                int t = t1 - (t2 * (r1 / r2));
                if (remainder == 0)
                {
                    if (r2 == 1)
                        return t2 > 0 ? t2 : t2+26;
                    else
                        return -1;
                }
                    
                t1 = t2;
                t2 = t;
                r1 = r2;
                r2 = remainder;
            };
        }
    }
}
