namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = Enumerable.Range(0, 1000000)
                                    .Select(_ => random.Next(10000, 99999));

            var palindromeNumbers = numbers
                .Where(n => IsPalindrome(n.ToString()));

            int palindromeCount = palindromeNumbers.Count();

            if (palindromeNumbers.Any())
            {
                Console.WriteLine("PalindromeNumbers");
                foreach (var palindrome in palindromeNumbers)
                {
                    Console.WriteLine(palindrome);
                }
                Console.WriteLine("Count:" + " " + palindromeCount);
            }
            else
            {
                Console.WriteLine("No palindrome numbers found.");
                Console.WriteLine("Count:" + " " + palindromeCount);
            }
        }
        static bool IsPalindrome(string s)
        {
            return s.SequenceEqual(s.Reverse());
        }
    }
}
