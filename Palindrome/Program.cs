using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                Console.WriteLine($"{args[i]} -> {isPalindrome(args[i])}");
            }
        }

        public static bool isPalindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException();
            }
            else if (word.Length < 2)
            {
                return true;
            }
            else
            {
                return CheckPalindrome(word);
            }

            bool CheckPalindrome(string word)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                if (word == reversedWord)
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
}
