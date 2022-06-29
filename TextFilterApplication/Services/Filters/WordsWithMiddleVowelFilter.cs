using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
        /// <inheritdoc />
        public string Apply(string inputText)
        {
            var words = inputText.Split(' ');

            var wordsAfterFilter = words.Where(word =>
            {
                var length = word.Length;
                var wordAsChars = word.ToCharArray();
                if (length % 2 == 0)
                {
                    //even number of letters
                    var centerIndexOne = (length / 2) - 1;
                    var charAtCenterIndex1 = wordAsChars[centerIndexOne];
                    if (CharIsAVowel(charAtCenterIndex1))
                    {
                        return false;
                    }

                    var centerIndexTwo = (length / 2);
                    var charAtCenterIndex2 = wordAsChars[centerIndexTwo];
                    if (CharIsAVowel(charAtCenterIndex2))
                    {
                        return false;
                    }
                }
                else
                {
                    //must be odd number of letters
                    var centerIndex = (length / 2);
                    var charAtCenterIndex = wordAsChars[centerIndex];
                    if (CharIsAVowel(charAtCenterIndex))
                    {
                        return false;
                    }
                }

                return true;
            });

            return string.Join(' ', wordsAfterFilter);
        }

        private bool CharIsAVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
    }
}
