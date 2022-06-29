using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Services.Readers;

namespace ServiceTests
{
    [TestClass]
    public class TextFromFileReaderTests
    {
        [TestMethod]
        public async Task TestGetStringFromEmbeddedResource()
        {
            string fileName = "TestTextFile1.txt";

            var textFromFileReader = new TextFromFileReader();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNamespace = $"{typeof(TextFromFileReaderTests).Namespace}";

            var result = await textFromFileReader.GetStringFromEmbeddedResourceTxtFile(assembly, resourceNamespace, fileName);

            string expectedText = "This is a test text file";

            Assert.AreEqual(expectedText, result);
        }
    }
}
