using System;
using System.Threading.Tasks;
using Autofac;

namespace TextFilterApplication
{
    internal class Program
    {
        public static async Task<int> Main(string[] args)
        {
            try
            {
                var container = ContainerConfiguration.BuildContainer();
                var app = container.Resolve<ITextFilterApp>();

                string fileName = "SampleText.txt";
                await app.RunFilterAgainstFileAsync(fileName);

                return 0;
            }
            catch (Exception exception)
            {
                ConsoleExtensions.WriteLineInColor($"Fatal error: '{exception.Message}'.", ConsoleColor.Red);
                return -1;
            }
        }
    }
}
