using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordle
{
    class main
    {
        public bool InYesNo(string[] ls, string word)
        {
            bool flag = false;
            foreach (string i in ls)
            {
                if (i == word)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public bool InYesNoChr(char[] ls, char word)
        {
            bool flag = false;
            foreach (char i in ls)
            {
                if (i == word)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public string[] Check(string word, string computer)
        {
            char[] ls2 = new char[5];
            for (int i = 0; i < 5; i++)
            {
                ls2[i] = computer[i];
            }

            string[] ls3 = { "0", "0", "0", "0", "0" };

            for (int k = 0; k < 5; k++)
            {
                if (word[k] == ls2[k])
                {
                    ls3[k] = "Green";
                    ls2[k] = '0';
                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (InYesNoChr(ls2, word[k]) && ls3[k] != "Green")
                {
                    ls3[k] = "Yellow";
                    int f = Array.IndexOf(ls2, word[k]);
                    ls2[f] = '0';
                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (ls3[k] == "0")
                {
                    ls3[k] = "Black";
                }
            }
            return ls3;
        }
    }
}
