using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Services.Readers
{
    /// <inheritdoc cref="ITextFromFileReader"/>
    public class TextFromFileReader : ITextFromFileReader
    {
        public async Task<string> GetStringFromEmbeddedResourceTxtFile(
            Assembly resourceAssembly,
            string resourceNamespace, 
            string fileName)
        {
            await using var stream = resourceAssembly.GetManifestResourceStream($"{resourceNamespace}.{fileName}");

            if (stream == null) 
                return string.Empty; //Consider using an exception here

            using var reader = new StreamReader(stream);
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
