namespace Application
{
    using System;
    using Operation;
    using static System.Console;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            Title = Text.TitleApp;

            bool exitProgram = false;
            string operands = string.Empty;

            while (!exitProgram)
            {
                Clear();

                Screen.Show(Text.MainMenu);
                ConsoleKey selectMenu = ReadKey().Key;

                if (Screen.IsSelectedOperation(selectMenu))
                {
                    Clear();
                    Screen.Show(Text.AboutInput);
                    operands = ReadLine();
                    double result;

                    try
                    {
                        if (Operation.CheckOperands(operands))
                        {
                            result = Operation.GetResultOperation((byte)selectMenu);

                            Screen.Show(string.Format(Text.ResultOperation, result));
                        }
                        else
                        {
                            Screen.Error();
                        }
                    }
                    catch (Exception ex)
                    {
                        Screen.Show(ex.Message);
                    }
                    finally
                    {
                        Screen.Show(Text.AnyPress);
                        ReadKey();
                    }
                }
                else
                {
                    if (selectMenu == ConsoleKey.Q)
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}