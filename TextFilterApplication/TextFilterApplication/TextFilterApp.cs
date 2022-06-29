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
        public TextFilterApp(
            ITextFromFileReader textFromFileReader,
            ITextFilterService textFilterService)
        {
            _textFromFileReader = textFromFileReader;
            _textFilterService = textFilterService;
        }

        public async Task RunFilterAgainstFileAsync(string fileName)
        {
            Console.WriteLine("This program will apply 3 filters to the text in the file");

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNamespace = $"{typeof(Program).Namespace}";

            var textFromFile = await _textFromFileReader.GetStringFromEmbeddedResourceTxtFile(assembly, resourceNamespace, fileName);

            string resultAfterFilters = _textFilterService.ApplyFilters(textFromFile);

            Console.WriteLine($"Result: {resultAfterFilters}");
        }
    }
}
