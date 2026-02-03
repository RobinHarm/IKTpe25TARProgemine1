
namespace Dicitonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary ja foreach");
            //var on muutuja
            var domains = new Dictionary<string, string>()
            {
              {"fi", "Finland" },
              {"se", "Sweden" },
              {"de", "German" },
              {"fr", "France" },
              {"es", "Spain" }
            };
            int i = 1;
            //kasutate foreachi ja juurde tuleb lisada kolmas rida
            foreach (var domain in domains)
            {
                    
                Console.WriteLine($"{domain.Key} - {domain.Value} - {i}");       
                i++;
            }
        }
    }
}
