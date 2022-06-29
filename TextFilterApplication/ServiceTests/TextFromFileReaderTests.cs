using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace ServiceTests
{
    [TestClass]
    public class TextFromFileReaderTests
    {
        [TestMethod]
        public void TestGetStringFromEmbeddedResource()
        {
            string fileName = "TestTextFile1.txt";

            var textFromFileReader = new TextFromFileReader();

            var result = textFromFileReader.GetStringFromEmbeddedResourceTxtFile();

            string expectedText = "This is a test text file";

            Assert.AreEqual(expectedText, result);
        }
    }
}
