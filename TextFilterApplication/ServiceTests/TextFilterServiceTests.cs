using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Services.Filters;
using Services.Readers;

namespace ServiceTests
{
    [TestClass]
    public class TextFilterServiceTests
    {
        private class RemoveVowelsFilter : IFilter
        {
            public string Apply(string inputText)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var c in inputText.ToCharArray())
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                        continue;

                    sb.Append(c);
                }

                return sb.ToString();
            }
        }

        [TestMethod]
        public void TestApplyFilterToInputText()
        {
            string inputText = "test text";

            string expectedText = "tst txt";

            var filters = new List<IFilter>()
            {
                new RemoveVowelsFilter()
            };

            var textFilterService = new TextFilterService(filters);

            var result = textFilterService.ApplyFilters(inputText);

            Assert.AreEqual(expectedText, result);
        }

        [TestMethod]
        public void TestWordsWithMiddleVowelFilter()
        {
            string inputText = "clean what currently the rather";

            string expectedText = "the rather";

            var wordsWithMiddleVowelFilter = new WordsWithMiddleVowelFilter();

            var result = wordsWithMiddleVowelFilter.Apply(inputText);

            Assert.AreEqual(expectedText, result);
        }

        [TestMethod]
        public void LengthLessThanThreeFilterFilter()
        {
            string inputText = "the ox said hello to me";

            string expectedText = "the said hello";

            var lengthLessThanThreeFilter = new LengthLessThanThreeFilter();

            var result = lengthLessThanThreeFilter.Apply(inputText);

            Assert.AreEqual(expectedText, result);
        }

        [TestMethod]
        public void WordsWithTFilterFilter()
        {
            string inputText = "the ant said hello to me";

            string expectedText = "said hello me";

            var wordsWithTFilter = new WordsWithTFilter();

            var result = wordsWithTFilter.Apply(inputText);

            Assert.AreEqual(expectedText, result);
        }
    }
}
