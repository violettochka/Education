namespace DictionaryImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dict<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            Console.WriteLine(dictionary.Find(1));
            dictionary.Remove(1);
            Console.WriteLine(dictionary.Find(1));
            dictionary.Contains(4);

            foreach(var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

            }
        }
    }
}
