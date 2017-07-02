namespace Application
{
    using System;
    using System.Globalization;
    using System.Threading;
    using static System.Console;

    internal static class Screen
    {
        private static dynamic selectedKey = new
        {
            ConsoleKey.D1,
            ConsoleKey.D2,
            ConsoleKey.D3,
            ConsoleKey.D4,
            ConsoleKey.NumPad1,
            ConsoleKey.NumPad2,
            ConsoleKey.NumPad3,
            ConsoleKey.NumPad4
        };

        public static void Show(params string[] textToShow)
        {
            foreach (var stringToShow in textToShow)
            {
                WriteLine(stringToShow);
            }
        }

        public static bool IsSelectedOperation(ConsoleKey selectCreateditem)
        {
            return selectCreateditem == selectedKey.D1 ||
                   selectCreateditem == selectedKey.D2 ||
                   selectCreateditem == selectedKey.D3 ||
                   selectCreateditem == selectedKey.D4 ||
                   selectCreateditem == selectedKey.NumPad1 ||
                   selectCreateditem == selectedKey.NumPad2 ||
                   selectCreateditem == selectedKey.NumPad3 ||
                   selectCreateditem == selectedKey.NumPad4;
        }

        public static void Error()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            string decimalSeparator = currentCulture.NumberFormat.NumberDecimalSeparator;

            Screen.Show(string.Format(Text.ErrorOperands, decimalSeparator));
        }
    }
}