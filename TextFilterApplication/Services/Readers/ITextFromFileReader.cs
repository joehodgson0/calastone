using System.Reflection;
using System.Threading.Tasks;

namespace Services.Readers
{
    /// <summary>
    /// Reads the text from a text file stored as an embedded resource
    /// </summary>
    public interface ITextFromFileReader
    {
        /// <summary>
        /// Gets the string contents from an embedded resource file
        /// </summary>
        /// <param name="resourceAssembly">the assembly containing the embedded resource</param>
        /// <param name="resourceNamespace">the namespace of the file within the assembly</param>
        /// <param name="fileName">the filename</param>
        /// <returns>the string contents</returns>
        Task<string> GetStringFromEmbeddedResourceTxtFile(
            Assembly resourceAssembly,
            string resourceNamespace,
            string fileName);
    }
}
