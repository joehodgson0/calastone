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
        string ApplyFilters(string inputText);
    }
}
