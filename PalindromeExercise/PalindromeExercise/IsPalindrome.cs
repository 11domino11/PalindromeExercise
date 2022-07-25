using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class IsPalindrome
    {
        public bool IsAPalindrome(string str)
        {
            if(str == "" || str == null || str == " ")
            {
                return false;
            }
            var reversed = "";
            for (int i = str.Length -1; i >= 0; i--)
            {
                reversed += str[i];
            }
            if(reversed == str)
            {
                return true;
            }else return false;
        }
    }
}
