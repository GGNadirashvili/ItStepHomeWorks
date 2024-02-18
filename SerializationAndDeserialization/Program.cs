using Newtonsoft.Json;

namespace SerializationAndDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySerializer serializer = new MySerializer();

            var obj = new { Name = "Giorgi", Age = 23 };
            string json = serializer.Serialize(obj);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            var newObj = serializer.Deserialize<dynamic>(json);
            Console.WriteLine("\nDeserialized Object:");
            Console.WriteLine($"Name: {newObj.Name}, Age: {newObj.Age}");
        }
    }

        public class MySerializer
        {
            public string Serialize(object obj)
            {
                return JsonConvert.SerializeObject(obj);
            }

            public T Deserialize<T>(string json)
            {
                return JsonConvert.DeserializeObject<T>(json)!;
            }
        }
}
