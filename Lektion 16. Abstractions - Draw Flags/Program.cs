using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lektion_16.Abstractions___Draw_Flags
{
    public class Program
    {
        public static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            //Row 1
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 0);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 2
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 1);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 3
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 2);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 4
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 3);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 5 - Only DarkYellow
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            //Row 6
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 5);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 7
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 6);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 8
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 7);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();

            //Row 9
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ColorSpacesAndSymbol(30, ' '));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 8);
            Console.WriteLine(ColorSpacesAndSymbol(2, ' '));
            Console.ResetColor();
        }

        public static string ColorSpacesAndSymbol(int spaces, char x) //Amount of spaces and char inside the color, to leave it blank just leave the parameter when you call it in main to ' '.
        {
            string space = "";

            for (int i = 0; i < spaces; i++)
            {
                space += x;
            }
            return space;
        }
        public static void SetPositionAndColor(ConsoleColor color, int column, int row)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(column, row);
        }
    }

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("Hello!", console.Output);
        }
    }
}