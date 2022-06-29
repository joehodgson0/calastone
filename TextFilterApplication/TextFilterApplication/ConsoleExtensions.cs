using System;

namespace TextFilterApplication
{
    public static class ConsoleExtensions
    {
        public static void WriteLineInColor(string text, ConsoleColor foreground)
        {
            WriteLineInColor(text, foreground, Console.BackgroundColor);
        }

        public static void WriteLineInColor(string text, ConsoleColor foreground, ConsoleColor background)
        {
            WriteInColor(text, foreground, background);
            Console.WriteLine();
        }

        public static void WriteInColor(string text, ConsoleColor foreground)
        {
            WriteInColor(text, foreground, Console.BackgroundColor);
        }

        public static void WriteInColor(string text, ConsoleColor foreground, ConsoleColor background)
        {
            ConsoleColor previousForeground = Console.ForegroundColor;
            ConsoleColor previousBackground = Console.BackgroundColor;
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Write(text);
            Console.ForegroundColor = previousForeground;
            Console.BackgroundColor = previousBackground;
        }
    }
}
