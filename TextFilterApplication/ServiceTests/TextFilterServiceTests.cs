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
    }
}
