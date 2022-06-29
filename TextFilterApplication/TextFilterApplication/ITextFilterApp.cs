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
        Task RunFilterAgainstFileAsync(string fileName);
    }
}
