using System;

namespace PallindromeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it's a palindrome:");
            string input = Console.ReadLine();

            // Call the IsPalindrome method
            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        }

        // Method to check if the string is a palindrome
        static bool IsPalindrome(string s)
        {
            // Remove non-alphanumeric characters and convert to lowercase
            var processedString = ProcessString(s);
            int start = 0;
            int end = processedString.Length - 1;

            while (start < end)
            {
                if (processedString[start] != processedString[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }

        // Helper method to clean up the string (remove non-alphanumeric, convert to lowercase)
        static string ProcessString(string s)
        {
            char[] arr = s.ToLower().ToCharArray();
            var sb = new System.Text.StringBuilder();
            foreach (char c in arr)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
