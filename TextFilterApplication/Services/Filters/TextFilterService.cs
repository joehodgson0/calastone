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

        /// <summary>
        /// IOC constructor
        /// </summary>
        /// <param name="filters">all available filters to apply</param>
        public TextFilterService(IEnumerable<IFilter> filters)
        {
            _filters = filters;
        }

        /// <inheritdoc />
        public string ApplyFilters(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText) && _filters.Any())
            {
                inputText = _filters.Aggregate(inputText, (current, filter) => filter.Apply(current));
            }

            return inputText;
        }
    }
}
