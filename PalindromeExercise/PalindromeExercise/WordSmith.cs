using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }
        public bool isaPalindrome(string input)
        {
            input = input.ToLower();

            char[] charArray = input.ToCharArray();

            Array.Reverse(charArray);

            var reverse = new string(charArray);

            return (input == reverse) ? true : false;
            
        }
    }
}
