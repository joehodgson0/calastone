using System.Reflection;
using System.Threading.Tasks;

namespace Services.Readers
{
    /// <summary>
    /// Reads the text from a text file stored as an embedded resource
    /// </summary>
    public interface ITextFromFileReader
    {
        Task<string> GetStringFromEmbeddedResourceTxtFile(
            Assembly resourceAssembly,
            string resourceNamespace,
            string fileName);
    }
}
