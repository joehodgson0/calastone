using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Services.Readers
{
    /// <inheritdoc cref="ITextFromFileReader"/>
    public class TextFromFileReader : ITextFromFileReader
    {
        /// <inheritdoc/>
        public async Task<string> GetStringFromEmbeddedResourceTxtFile(
            Assembly resourceAssembly,
            string resourceNamespace, 
            string fileName)
        {
            var fullFileName = $"{resourceNamespace}.{fileName}";
            await using var stream = resourceAssembly.GetManifestResourceStream(fullFileName);

            if (stream == null)
                throw new ApplicationException($"Cannot load stream from embedded resource file at {fullFileName}");

            using var reader = new StreamReader(stream);
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
