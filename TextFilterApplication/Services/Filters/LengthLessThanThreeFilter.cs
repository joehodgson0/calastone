using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Filters
{
    /// <summary>
    /// filter out words that have length less than 3
    /// </summary>
    public class LengthLessThanThreeFilter : IFilter
    {
        public string Apply(string inputText)
        {
            var words = inputText.Split(' ');

            var wordsAfterFilter = words.Where(word => word.Length > 2);

            return string.Join(' ', wordsAfterFilter);
        }
    }
}
