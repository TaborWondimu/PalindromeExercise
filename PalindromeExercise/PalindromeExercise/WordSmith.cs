using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
 public  class WordSmith
    {
    public bool ISAPalindrome(string str)
        {
         if (str == null)
            {
             return false;
            }
            /*   var reversed = "";
            for(int i = str.Length -1; i >= 0; i--)
               {
                   reversed += str[i].ToString();
               }
             if( reversed == str)
               {
                   return true;
               }
               else
               {
                   return false;
               }
            */
            // this is refractoring the code
            return str.SequenceEqual(str.Reverse());
        }
    }
}
