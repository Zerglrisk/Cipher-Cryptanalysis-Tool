using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCryptanalysisTool
{
    class AES
    {
        private byte[,] SubByte_transformation_table = new byte[16, 16] {
            {0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76},
            {0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0},
            {0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15},
            {0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75},
            {0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84},
            {0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf},
            {0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8},
            {0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2},
            {0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73},
            {0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb},
            {0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79},
            {0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08},
            {0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a},
            {0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e},
            {0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf},
            {0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16} };

        private byte[,] InvSubByte_transformation_table = new byte[16, 16] {
            {0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb},
            {0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb},
            {0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e},
            {0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25},
            {0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92},
            {0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84},
            {0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06},
            {0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b},
            {0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73},
            {0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e},
            {0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b},
            {0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4},
            {0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f},
            {0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef},
            {0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61},
            {0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d} };
        private byte[,] RCon = new byte[14, 4] {{0x00, 0x00, 0x00, 0x00},
                                        {0x01, 0x00, 0x00, 0x00},
                                        {0x02, 0x00, 0x00, 0x00},
                                        {0x04, 0x00, 0x00, 0x00},
                                        {0x08, 0x00, 0x00, 0x00},
                                        {0x10, 0x00, 0x00, 0x00},
                                        {0x20, 0x00, 0x00, 0x00},
                                        {0x40, 0x00, 0x00, 0x00},
                                        {0x80, 0x00, 0x00, 0x00},
                                        {0x1B, 0x00, 0x00, 0x00},
                                        {0x36, 0x00, 0x00, 0x00},
                                        {0x6C, 0x00, 0x00, 0x00},
                                        {0xD8, 0x00, 0x00, 0x00},
                                        {0xAB, 0x00, 0x00, 0x00}};
        private byte[,] state;
        private byte[] key;
        private byte[,] w;//[a,b]에서 a : 몇번째의 w, b : 4개의 byte 값들
        //byte[] w0, w1, w2, w3;

        private int Nr; //Round : 10, 12, 14
        private int MasterKeySize; //Nk, Key Size : 128bit(4Word), 192bit(6Word), 256bit(8Word)
        private int Nb = 4;

        /* 
         * Constructor
         */
        public AES() { }
        public AES(int Nr, int MasterKeySize)
        {
            this.Nr = Nr;
            this.MasterKeySize = MasterKeySize;
        }

        /*
         * Getter or Setter
         */
        public int getNr()
        {
            return this.Nr;
        }
        public void setNr(int Nr)
        {
            this.Nr = Nr;
        }
        public int getMasterKeySize()
        {
            return this.MasterKeySize;
        }
        public void setMasterKeySize(int MasterKeySize)
        {
            this.MasterKeySize = MasterKeySize;
        }



        /*
         * 암호화 하는 함수
         * 순서는 AddRoundKey 후 각 라운드 수 만큼 SubBytes->ShiftRows->MixColumns->AddRoundKey를 한다.
         * 단, 마지막 라운드에는 MixColumns는 하지 않는다.
         */
        public string Encrypt(string str, string key)
        {
            byte[] plainText = StringToByte(str, 0);
            int count = 0;
            byte[] cipherText = new byte[plainText.Length];
            
            this.key = KeyStringToByte(key);

            KeyExpansion();

            for (int i = 0; i < plainText.Length / 16; i++)
            {
                state = BlocktoState(plainText, i*16);
                
                state = AddRoundKey(state, 0);
                for (int round = 1; round <= Nr; round++)
                {
                    state = SubBytes(state);
                    state = ShiftRows(state);
                    if (round != Nr) MixColumns();
                    state = AddRoundKey(state, round);
                }
                var temp = StatetoBlock(state);
                for (int j = 0 ; j < temp.Length; j++)
                    cipherText[count++] = temp[j];
                
            }
            return ByteToString(cipherText, 0);
        }

        /*
         * 복호화 하는 함수
         * 순서는 암호화의 반대로, AddRoundKey 후 각 라운드 수 만큼 InvShiftRows->InvSubBytes->AddRoundKey->InvMixColumn를 한다.
         * 단, 마지막 라운드에는 InvMixColumns를 하지 않는다.
         */
        public string Decrypt(string str, string key)
        {
            byte[] cipherText = StringToByte(str, 1);
            int count = 0;
            byte[] plainText = new byte[cipherText.Length]; ;

            this.key = KeyStringToByte(key);

            KeyExpansion();
            for (int i = 0; i < cipherText.Length / 16; i++)
            {
                state = BlocktoState(cipherText, i*16);

                state = AddRoundKey(state, Nr);
                for (int round = Nr - 1; round >= 0; round--)
                {
                    state = InvShiftRows(state);
                    state = InvSubBytes(state);
                    state = AddRoundKey(state, round);
                    if (round != 0) InvMixColumns();
                }
                var temp = StatetoBlock(state);
                for (int j = 0; j < temp.Length; j++)
                    plainText[count++] = temp[j];

            }
            return ByteToString(plainText, 1);
        }
        public byte[] KeyStringToByte(string str)
        {
            //this.key = new byte[MasterKeySize * 4]
            byte[] StrByte;
            byte[] temp;
            temp = Encoding.UTF8.GetBytes(str);

            if (temp.Length % (MasterKeySize * 4) != 0 || temp.Length == 0)
                StrByte = new byte[temp.Length + ((MasterKeySize * 4) - (temp.Length % (MasterKeySize * 4)))];
            else
                StrByte = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                StrByte[i] = temp[i];
            }
            if (temp.Length % (MasterKeySize * 4) != 0)
                for (int i = temp.Length; i < StrByte.Length; i++)
                {
                    StrByte[i] = 0x00;
                }

            return StrByte;
        }
        /*
         * refer : http://zephie.tistory.com/11
         * 이는 String을 Byte로 변환하는 함수이다.
         * refer : http://stackoverflow.com/questions/951487/how-to-convert-a-byte-array-to-a-string
         * 한글의 암호화를 위해서 바이트로 변환할때 사용하는 함수는 다음과 같이 암호화할떄는 Encoding.URF8.GetBytes()이고, 
         * 복호화할때 바이트로 변환하는 함수는 Convert.FromBase64String()이다.
         * 만약 string의 길이가 16으로 나누어 떨어지지 않고 나머지가 있으면, 배열을 16더 늘려, 있는 부분까지 채우고, 부족한 부분은 0x00으로 패딩한다.
         */
        private byte[] StringToByte(string str, int mode)
        {
            byte[] StrByte;
            byte[] temp;
            if (mode == 0) //encrypt
                temp = Encoding.UTF8.GetBytes(str);
            else //decrypt
                temp = Convert.FromBase64String(str);
            if (temp.Length % 16 != 0 || temp.Length == 0)
                StrByte = new byte[temp.Length + (16 - (temp.Length % 16))];
            else
                StrByte = new byte[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                StrByte[i] = temp[i];
            }
            if (temp.Length % 16 != 0)
                for (int i = temp.Length; i < StrByte.Length; i++)
                {
                    StrByte[i] = 0x00;
                }

            return StrByte;
        }
        /*
         * refer : http://zephie.tistory.com/11
         * 이는 Byte을 String로 변환하는 함수이다.
         * refer : http://stackoverflow.com/questions/951487/how-to-convert-a-byte-array-to-a-string
         * 한글의 암호화를 위해서 바이트를 스트링으로 변환할때 사용하는 함수는 다음과 같이 암호화할떄는 Convert.ToBase64String()이고, 
         * 복호화할때 스트링으로 변환하는 함수는 Encoding.UTF8.GetString()이다.
         */
        private string ByteToString(byte[] strByte, int mode)
        {
            string str;
            if (mode == 0)//encrypt
                str = Convert.ToBase64String(strByte);//Encoding.UTF8.GetString(strByte);
            else
                str = Encoding.UTF8.GetString(strByte);
            return str;
        }
        /*
         * 4개의 Block(4 Byte)을 State(배열)로 바꾸는 것이다. 
         */
        private byte[,] BlocktoState(byte[] strByte, int startpos)
        {
            byte[,] bytes = new byte[4, 4];

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[i, j] = strByte[startpos++];
                }
            }
            return bytes;
        }
        /*
         * State(배열)을 4개의 Block(4 Byte)로 바꾸는 것이다. 
         */
        private byte[] StatetoBlock(byte[,] bytes)
        {
            byte[] strByte = new byte[16];
            int n = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    strByte[n++] = bytes[i, j];
                }
            }
            return strByte;
        }
        private byte[,] SubBytes(byte [,] bytes)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[j, i] = SubByte_transformation_table[bytes[j, i] >> 4, bytes[j, i] & 0x0F];
                }
            }
            return bytes;
        }
        private byte[,] InvSubBytes(byte[,] bytes)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[j, i] = InvSubByte_transformation_table[bytes[j, i] >> 4, bytes[j, i] & 0x0F];
                }
            }
            return bytes;
        }
        /*
         * PPT의 의사코드에서는 (c-n) mod 4로 되어있는데 -로 하면 암복호화가 제대로 활성화 하지않았다.
         * refer : http://www.slideshare.net/hisunilkumarr/advanced-encryption-sta
         * 참조  21P(책안에서는 13P)의 의사코드에 의하면 [c+r]이 되어 있다. 따라서 c-n이 아니라 c+n으로 구현하였다.
         */
        private byte[,] ShiftRows(byte[,] bytes)
        {
            byte[,] temp = new byte[4,4];
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    temp[j, i] = state[j, i];

            for (int j = 1; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[j, i] = temp[j, (i+j)%Nb];
                }
            }
            return bytes;
        }
        private byte[,] InvShiftRows(byte[,] bytes)
        {
            byte[,] temp = new byte[4, 4];
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    temp[j, i] = state[j, i];
        
            for (int j = 1; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    bytes[j, (i + j) % Nb] = temp[j, i];
                }
            }
            return bytes;
        }
        private void MixColumns()
        {
            byte[,] temp = new byte[4, 4];
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    temp[j, i] = state[j, i];

            for (int i = 0; i < 4; i++)
            {
                state[0, i] = (byte)(Mux4MixColumn(2, temp[0, i]) ^ Mux4MixColumn(3, temp[1, i]) ^ temp[2, i] ^ temp[3, i]);
                state[1, i] = (byte)(temp[0, i] ^ Mux4MixColumn(2, temp[1, i]) ^ Mux4MixColumn(3, temp[2, i]) ^ temp[3, i]);
                state[2, i] = (byte)(temp[0, i] ^ temp[1, i] ^ Mux4MixColumn(2, temp[2, i]) ^ Mux4MixColumn(3, temp[3, i]));
                state[3, i] = (byte)(Mux4MixColumn(3, temp[0, i]) ^ temp[1, i] ^ temp[2, i] ^ Mux4MixColumn(2, temp[3, i]));
            }
        }
        private void InvMixColumns()
        {
            byte[,] temp = new byte[4, 4];
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 4; i++)
                    temp[j, i] = state[j, i];

            for (int i = 0; i < 4; i++)
            {
                state[0, i] = (byte)(Mux4MixColumn(4, temp[0, i]) ^ Mux4MixColumn(5, temp[1, i]) ^ Mux4MixColumn(6, temp[2, i]) ^ Mux4MixColumn(7, temp[3, i]));
                state[1, i] = (byte)(Mux4MixColumn(7, temp[0, i]) ^ Mux4MixColumn(4, temp[1, i]) ^ Mux4MixColumn(5, temp[2, i]) ^ Mux4MixColumn(6, temp[3, i]));
                state[2, i] = (byte)(Mux4MixColumn(6, temp[0, i]) ^ Mux4MixColumn(7, temp[1, i]) ^ Mux4MixColumn(4, temp[2, i]) ^ Mux4MixColumn(5, temp[3, i]));
                state[3, i] = (byte)(Mux4MixColumn(5, temp[0, i]) ^ Mux4MixColumn(6, temp[1, i]) ^ Mux4MixColumn(7, temp[2, i]) ^ Mux4MixColumn(4, temp[3, i]));
            }
        }
            
        private byte Mux4MixColumn(int startKeyue, byte bytes)
        {
            byte temp, temp2, temp3;

            switch (startKeyue)
            {
                case 1: //0x01
                    break;
                case 2: //0x02
                    if (bytes >= 0x80)
                        bytes = (byte)((bytes << 1) ^ 0x1B);
                    else
                        bytes = (byte)(bytes << 1);
                    break;
                case 3: //0x03
                    if (bytes >= 0x80)
                        bytes = (byte)((bytes << 1) ^ 0x1B ^ bytes);
                    else
                        bytes = (byte)((bytes << 1) ^ bytes);
                    break;
                case 4: //0x0E
                    temp = bytes;
                    if (temp >= 0x80)
                        temp = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp = (byte)(temp << 1);
                    if (temp >= 0x80)
                        temp2 = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp2 = (byte)(temp << 1);
                    if (temp2 >= 0x80)
                        temp3 = (byte)((temp2 << 1) ^ 0x1B);
                    else
                        temp3 = (byte)(temp2 << 1);
                    bytes = (byte)(temp ^ temp2 ^ temp3);
                    break;
                case 5: //0x0B
                    temp = bytes;
                    if (temp >= 0x80)
                        temp = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp = (byte)(temp << 1);
                    if (temp >= 0x80)
                        temp2 = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp2 = (byte)(temp << 1);
                    if (temp2 >= 0x80)
                        temp3 = (byte)((temp2 << 1) ^ 0x1B);
                    else
                        temp3 = (byte)(temp2 << 1);
                    bytes = (byte)(temp ^ bytes ^ temp3);
                    break;
                case 6: //0x0D
                    temp = bytes;
                    if (temp >= 0x80)
                        temp = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp = (byte)(temp << 1);
                    if (temp >= 0x80)
                        temp2 = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp2 = (byte)(temp << 1);
                    if (temp2 >= 0x80)
                        temp3 = (byte)((temp2 << 1) ^ 0x1B);
                    else
                        temp3 = (byte)(temp2 << 1);
                    bytes = (byte)(bytes ^ temp2 ^ temp3);
                    break;
                case 7: //0x09
                    temp = bytes;
                    if (temp >= 0x80)
                        temp = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp = (byte)(temp << 1);
                    if (temp >= 0x80)
                        temp2 = (byte)((temp << 1) ^ 0x1B);
                    else
                        temp2 = (byte)(temp << 1);
                    if (temp2 >= 0x80)
                        temp3 = (byte)((temp2 << 1) ^ 0x1B);
                    else
                        temp3 = (byte)(temp2 << 1);
                    bytes = (byte)(bytes ^ temp3);
                    break;
            }
            return bytes;
        }
        /*
         * 각 스테이트 열행렬에 라운드 키 워드를 더하는 함수
         * 한 번에 한 열 씩 수행한다. 키 워드는 1byte로 되어 있으므로(w[번째,4바이트값]) i번재의 값을 순서대로 xor하여 넣어준다.
         */
        private byte[,] AddRoundKey(byte[,] bytes, int round)
        {
            for (int i = 0; i < 4; i++)
            {
                bytes[0, i] = (byte)(bytes[0, i] ^ w[round * 4+i, 0]);
                bytes[1, i] = (byte)(bytes[1, i] ^ w[round * 4+i, 1]);
                bytes[2, i] = (byte)(bytes[2, i] ^ w[round * 4+i, 2]);
                bytes[3, i] = (byte)(bytes[3, i] ^ w[round * 4+i, 3]);
            }
            return bytes; 
        }
        /*
         * Key확장을 한다. w(word)의 개수는 (Nr+1)*MasterKeySize(라운드x각 모드의 키사이즈(word단위))
         * 이때 key의 크기가 부족할 경우 빈칸은 0x00로 채우는 것은 StringToByte함수에서 한다.
         */
        private void KeyExpansion()
        {
            w = new byte[(Nr + 1) * Nb, 4];
            byte[] t = new byte[4];

            for (int j = 0; j < MasterKeySize; j++)
            {
                w[j, 0] = key[4 * j];
                w[j, 1] = key[4 * j + 1];
                w[j, 2] = key[4 * j + 2];
                w[j, 3] = key[4 * j + 3];
            }

            for(int j= MasterKeySize; j< (Nr + 1) * Nb; j++)
            {
                if (MasterKeySize == 8 && j % 4 == 0 && j % MasterKeySize != 0)
                {
                    t[0] = w[j - 1, 0];
                    t[1] = w[j - 1, 1];
                    t[2] = w[j - 1, 2];
                    t[3] = w[j - 1, 3];

                    t = SubWord(t);

                    w[j, 0] = (byte)(w[j - MasterKeySize, 0] ^ t[0]);
                    w[j, 1] = (byte)(w[j - MasterKeySize, 1] ^ t[1]);
                    w[j, 2] = (byte)(w[j - MasterKeySize, 2] ^ t[2]);
                    w[j, 3] = (byte)(w[j - MasterKeySize, 3] ^ t[3]);
                }
                else if (j % MasterKeySize != 0)
                {
                    w[j, 0] = (byte)(w[j - MasterKeySize, 0] ^ w[j - 1, 0]);
                    w[j, 1] = (byte)(w[j - MasterKeySize, 1] ^ w[j - 1, 0]);
                    w[j, 2] = (byte)(w[j - MasterKeySize, 2] ^ w[j - 1, 0]);
                    w[j, 3] = (byte)(w[j - MasterKeySize, 3] ^ w[j - 1, 0]);
                }
                
                else
                {
                    t[0] = w[j - 1, 0];
                    t[1] = w[j - 1, 1];
                    t[2] = w[j - 1, 2];
                    t[3] = w[j - 1, 3];

                    t = SubWord(RotWord(t));

                    t[0] = (byte)(t[0] ^ RCon[j / MasterKeySize, 0]);
                    //RCon 콘스탄트르를 보면, 제일 앞자리, 즉 t[0]만 쓰기 떄문에, 나머지는 계산하여 대입할 필요가 없다.
                    //t[1] = (byte)(t[1] ^ RCon[j / MasterKeySize, 1]);
                    //t[2] = (byte)(t[2] ^ RCon[j / MasterKeySize, 2]);
                    //t[3] = (byte)(t[3] ^ RCon[j / MasterKeySize, 3]);
                    w[j, 0] = (byte)(w[j - MasterKeySize, 0] ^ t[0]);
                    w[j, 1] = w[j - MasterKeySize, 1];
                    w[j, 2] = w[j - MasterKeySize, 2];
                    w[j, 3] = w[j - MasterKeySize, 3];
                    //w[j, 0] = (byte)(w[j - MasterKeySize, 0] ^ t[0]);
                    //w[j, 1] = (byte)(w[j - MasterKeySize, 1] ^ t[1]); 
                    //w[j, 2] = (byte)(w[j - MasterKeySize, 2] ^ t[2]);
                    //w[j, 3] = (byte)(w[j - MasterKeySize, 3] ^ t[3]);
                    int jj = j / MasterKeySize;
                }

            }
        }
        /*
         * refer : https://www.ime.usp.br/~rt/cranalysis/AESSimplified.pdf
         * This does a circular shift on 4 bytes similar to the Shift Row Function
         * 이 함수는 4byte씩 를 쉬프트한 것이다.
         * ex) 1,2,3,4 to 2,3,4,1
         */
        private byte [] RotWord(byte[] bytes)
        {
            var temp = bytes[0];
            bytes[0] = bytes[1];
            bytes[1] = bytes[2];
            bytes[2] = bytes[3];
            bytes[3] = temp;
            return bytes;
        }
        /*
         * refer : https://www.ime.usp.br/~rt/cranalysis/AESSimplified.pdf
         * This step applies the S-box value substitution as described in Bytes Sub function to each of the 4 bytes in the argument.
         * 이 함수는 S-box 값을 치환 한것과 같다. refer에서 볼 수 있듯이 S-box의 값들은 SubByte_transformation_table와 같다
         */
        private byte [] SubWord(byte[] bytes)
        {
            bytes[0] = SubByte_transformation_table[bytes[0] >> 4, bytes[0] & 0x0F];
            bytes[1] = SubByte_transformation_table[bytes[1] >> 4, bytes[1] & 0x0F];
            bytes[2] = SubByte_transformation_table[bytes[2] >> 4, bytes[2] & 0x0F];
            bytes[3] = SubByte_transformation_table[bytes[3] >> 4, bytes[3] & 0x0F];
            return bytes;
        }
    }
}
//http://www.nullskull.com/a/1127/advanced-encryption-standerd-aes-encryption-using-c--a-data-security.aspx
//http://huammmm1.tistory.com/381
//http://reinliebe.tistory.com/37
//http://www.cs.utsa.edu/~wagner/laws/AESintro.html -> http://www.cs.utsa.edu/~wagner/lawsbookcolor/laws.pdf