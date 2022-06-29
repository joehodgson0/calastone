using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Filters
{
    /// <summary>
    /// filter out words that contains the letter ‘t’
    /// </summary>
    public class WordsWithTFilter : IFilter
    {
        /// <inheritdoc />
        public string Apply(string inputText)
        {
            var words = inputText.Split(' ');

            var wordsAfterFilter = words.Where(word => !word.Contains('t'));

            return string.Join(' ', wordsAfterFilter);
        }
    }
}
