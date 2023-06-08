using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private bool isPalindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word));
            }
            else if (word.Length < 2)
            {
                return true
            }
        }
    }
}
