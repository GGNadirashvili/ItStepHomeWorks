using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\georg\\OneDrive\\Desktop\\records.txt";

        Console.WriteLine("Enter Some Text:");
        string userInput = Console.ReadLine();

        string[] records = {
            userInput!
        };

        WriteRecordsToFile(filePath, records);

        ReadRecordsFromFile(filePath);
    }

    static void WriteRecordsToFile(string filePath, string[] records)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        {
            foreach (string record in records)
            {
                byte[] recordBytes = Encoding.UTF8.GetBytes(record + Environment.NewLine);

                fileStream.Write(recordBytes, 0, recordBytes.Length);
            }
        }
        Console.WriteLine("Records have been written to the file.");
    }

    static void ReadRecordsFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
