
namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPalindrome = isPalindromeNumber(9013109);
            Console.WriteLine(isPalindrome);
        }

        private static bool isPalindromeNumber(int x)
        {
            if(x < 0) return false;
            int temp = x;
            int reversed = 0;

            
            while (temp > 0)
            {
                int digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }

            return reversed == x;
        }
    }
}
