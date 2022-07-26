using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
 
namespace PalindromeExercise
{
   public class Wordsmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null || word.Length == 0)
            {
                return false;
            }

            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word.ToLower()[i];
            }

            if (reversed == word.ToLower())
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
