using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Filters
{
    /// <summary>
    /// filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters
    /// ("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather"
    /// should not be)
    /// </summary>
    public class WordsWithMiddleVowelFilter : IFilter
    {
        public string Apply(string inputText)
        {
            throw new NotImplementedException();
        }
    }
}
