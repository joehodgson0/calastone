using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Filters
{
    /// <summary>
    /// A filter which can be applied on an input text string
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Apply the filter
        /// </summary>
        /// <param name="inputText">the input text</param>
        /// <returns>the result after the filter</returns>
        string Apply(string inputText);
    }
}
