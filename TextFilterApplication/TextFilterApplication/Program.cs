using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Services.Filters;
using Services.Readers;

namespace TextFilterApplication
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("This program will apply 3 filters to the text in the file");

            string fileName = "SampleText.txt";

            var textFromFileReader = new TextFromFileReader();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNamespace = $"{typeof(Program).Namespace}";

            var textFromFile = await textFromFileReader.GetStringFromEmbeddedResourceTxtFile(assembly, resourceNamespace, fileName);

            var filters = new List<IFilter>()
            {
                new WordsWithMiddleVowelFilter(),
                new LengthLessThanThreeFilter(),
                new WordsWithTFilter(),
            };

            var textFilterService = new TextFilterService(filters);

            string resultAfterFilters = textFilterService.ApplyFilters(textFromFile);

            Console.WriteLine($"Result: {resultAfterFilters}");

        }
    }
}
