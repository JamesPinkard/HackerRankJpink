using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public class CaeserCipher
    {
        public static void Solve(string[] args) {
            int stringLen = Convert.ToInt32(Console.ReadLine());
            string phrase = Console.ReadLine();
            int rotationNum = Convert.ToInt32(Console.ReadLine());

            string encryptedPhrase = CaeserEncrypt(stringLen, phrase, rotationNum);
            Console.WriteLine(encryptedPhrase);
        }

        public static string CaeserEncrypt(int stringLen, string phrase, int rotationNum)
        {
            char[] phraseChars = phrase.ToCharArray();
            char[] resultChars = new char[stringLen];
            for (int i = 0; i < stringLen; i++)
            {
                int charNumber = (int)phraseChars[i];
                if (charNumber >= 65 && charNumber <= 90)
                {
                    int alphaNum = charNumber - 65;
                    int encryptedNum = (alphaNum + rotationNum) % 26;
                    int UppercaseNum = encryptedNum + 65;
                    char UppercaseChar = (char)UppercaseNum;
                    resultChars[i] = UppercaseChar;
                }               
                
                else if (charNumber >= 97 && charNumber <= 122)
                {
                    int alphaNum = charNumber - 97;
                    int encryptedNum = (alphaNum + rotationNum) % 26;
                    int LowercaseNum = encryptedNum + 97;
                    char LowercaseChar = (char)LowercaseNum;
                    resultChars[i] = LowercaseChar;
                }

                else
                {
                    resultChars[i] = phraseChars[i];
                }
            }
            string resultString = new String(resultChars);
            return resultString;
        }        
    }
}
