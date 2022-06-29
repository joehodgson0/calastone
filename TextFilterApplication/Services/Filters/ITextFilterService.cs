using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Filters
{
    /// <summary>
    /// Service to apply filters to input text
    /// </summary>
    public interface ITextFilterService
    {
        /// <summary>
        /// Applies all filters to the input text
        /// </summary>
        /// <param name="inputText">the input text</param>
        /// <returns>the result of applying all filters</returns>
        string ApplyFilters(string inputText);
    }
}
