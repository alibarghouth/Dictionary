
using Dictionaries;
using System.Diagnostics.Metrics;

namespace Dictinaries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Country india = new Country("INDIA", "in", "20h", 20000000); 
            Country egipt = new Country("Egipt", "Eg", "20p", 10000000);
            var dictionary = new Dictionary<String, Country> { {india.Code,india },{ egipt.Code,egipt} };
            Country Country = dictionary[india.Code];
            Console.WriteLine(Country.Name);
            Console.WriteLine(dictionary.Count);
            bool exist =  dictionary.TryGetValue("in",out Country country);
            dictionary.Remove(india.Code.ToString());
            if (exist)
            {
                Console.WriteLine(country.Name);
            }
            else
            {
                Console.WriteLine("error");
            }
            foreach(var b in dictionary)
            {
                Console.WriteLine(b.Value.Name);
            }
        }
    }
}