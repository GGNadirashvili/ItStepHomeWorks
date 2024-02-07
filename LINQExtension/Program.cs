namespace LINQExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int iteration = 1000;

            // Create List with ints
            List<int> intList = new List<int>();

            for (int i = 0; i < iteration; i++)
            {
                int randomNumbers = random.Next(100, 1000);
                intList.Add(randomNumbers);
            }

            // Create List with strings

            List<string> stringList = new List<string>();

            for (int i = 0; i < iteration; i++)
            {
                int randomNumbers = random.Next(100, 1000);
                stringList.Add(randomNumbers.ToString());
            }

            // Concatenate the two lists
            List<string> concatenatedList = new List<string>();

            foreach (var num in intList)
            {
                concatenatedList.Add(num.ToString());
            }

            // Add all elements from stringList to concatenatedList
            concatenatedList.AddRange(stringList);

            // Remove dublications
            var removedDublicates = concatenatedList.Distinct().ToList();

            Console.WriteLine($"There is {removedDublicates.Count()} duplication in the List");

        }
    }
}
