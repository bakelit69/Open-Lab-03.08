using System;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            char lastChar = word[word.Length - 1];
            if (lastChar == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
