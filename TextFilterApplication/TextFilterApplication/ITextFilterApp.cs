using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterApplication
{
    /// <summary>
    /// Application that runs the filters against a sample text
    /// </summary>
    internal interface ITextFilterApp
    {
        /// <summary>
        /// Run all filters against the text in the input file
        /// </summary>
        /// <param name="fileName">the filename of the file containing the text</param>
        /// <returns>the result after applying the filters</returns>
        Task RunFilterAgainstFileAsync(string fileName);
    }
}
