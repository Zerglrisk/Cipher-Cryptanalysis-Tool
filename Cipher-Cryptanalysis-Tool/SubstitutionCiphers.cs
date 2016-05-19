using System;

namespace CipherCryptanalysisTool
{
    public class SubstitutionCiphers
    {
        public string AdditiveCipher_Encrypt(char [] array, int startKey, int endKey)
        {
            string encrypt = "";
            for (int i = startKey; i <= endKey; i++)
            {
                encrypt += "Key : " + i.ToString() + "'s Encrypt\r\n";
                for (int j = 0; j < array.Length; j++)
                {
                    int num = array[j];
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
            return encrypt.ToUpper();
        }
        public string AdditiveCipher_Decrypt(char[] array, int startKey, int endKey)
        {
            string decrypt = "";
            for (int i = startKey; i <= endKey; i++)
            {
                decrypt += "Key : " + i.ToString() + "'s Decrypt\r\n";
                for (int j = 0; j < array.Length; j++)
                {
                    int num = array[j];
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
            return decrypt.ToLower();
        }
       public string MultiplicativeCipher_Encrypt(char[] array, int startKey, int endKey)
        {
            string encrypt = "";
            for (int i = startKey; i <= endKey; i++)
            {
                encrypt += "Key : " + i.ToString() + "'s Encrypt\r\n";
                for (int j = 0; j < array.Length; j++)
                {
                    int num = array[j];
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
            return encrypt.ToUpper();
        }
        public string MultiplicativeCipher_Decrypt(char[] array, int startKey, int endKey)
        {
            string decrypt = "";
            for (int i = startKey; i <= endKey; i++)
            {
                decrypt += "Key : " + i.ToString() + "'s Decrypt\r\n";
                int key;
                if ((key = FindGCDRelativePrime(26, i)) == -1)
                {
                    decrypt += "Key의 역원이 없음.\r\n\r\n";
                    continue;
                }
                for (int j = 0; j < array.Length; j++)
                {
                    int num = array[j];

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
            return decrypt.ToLower();
        }
        /*
         * GCD 구하는 함수
         * 소수인지 아닌지 확인하기 위해 사용
         */
        private int FindGCDRelativePrime(int r1, int r2)
        {
            r1 = Math.Abs(r1);
            r2 = Math.Abs(r2);
            int t1 = 0, t2 = 1;

            // Pull out remainders.
            for (;;)
            {
                int remainder = r1 % r2;
                int t = t1 - (t2 * (r1 / r2));
                if (remainder == 0)
                {
                    if (r2 == 1)
                        return t2 > 0 ? t2 : t2 + 26;
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