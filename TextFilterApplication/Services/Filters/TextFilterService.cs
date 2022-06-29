using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Filters
{
    /// <inheritdoc cref="ITextFilterService"/>
    public class TextFilterService : ITextFilterService
    {
        private readonly IEnumerable<IFilter> _filters;

        public TextFilterService(IEnumerable<IFilter> filters)
        {
            _filters = filters;
        }

        public string ApplyFilters(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText))
            {
                inputText = _filters.Aggregate(inputText, (current, filter) => filter.Apply(current));
            }

            return inputText;
        }
    }
}
