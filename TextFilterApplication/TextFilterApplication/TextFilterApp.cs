using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Services.Filters;
using Services.Readers;

namespace TextFilterApplication
{
    /// <inheritdoc cref="ITextFilterApp"/>
    internal class TextFilterApp : ITextFilterApp
    {
        private readonly ITextFromFileReader _textFromFileReader;
        private readonly ITextFilterService _textFilterService;

        /// <summary>
        /// IOC Constructor
        /// </summary>
        /// <param name="textFromFileReader">Reads the text from a file</param>
        /// <param name="textFilterService">applies all the filters</param>
        public TextFilterApp(
            ITextFromFileReader textFromFileReader,
            ITextFilterService textFilterService)
        {
            _textFromFileReader = textFromFileReader;
            _textFilterService = textFilterService;
        }

        /// <inheritdoc/>
        public async Task RunFilterAgainstFileAsync(string fileName)
        {
            Console.WriteLine("This program will apply 3 filters to the text in the file");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNamespace = $"{typeof(Program).Namespace}";

            var textFromFile = await _textFromFileReader.GetStringFromEmbeddedResourceTxtFile(assembly, resourceNamespace, fileName);

            string resultAfterFilters = _textFilterService.ApplyFilters(textFromFile);

            var newLine = Environment.NewLine;
            string resultWithoutCarriageReturns = resultAfterFilters.Replace(newLine, " ");

            Console.WriteLine();
            Console.WriteLine($"Result: {resultAfterFilters}");
            Console.WriteLine();
            Console.WriteLine($"Result without carriage returns: {resultWithoutCarriageReturns}");
        }
    }
}
