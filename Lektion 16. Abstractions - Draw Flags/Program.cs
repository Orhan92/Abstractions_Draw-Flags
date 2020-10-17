using System;
using System.Collections.Generic;
using System.Data;
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

            ColorRowsAndSpaces(ConsoleColor.Blue, 30, 4); //4 rows of Blue
            Console.ResetColor();

            ColorRowsAndSpaces(ConsoleColor.DarkYellow, 30, 1); //1 row of Dark yellow
            Console.ResetColor();

            ColorRowsAndSpaces(ConsoleColor.Blue, 30, 4); //4 Rows of blue
            Console.ResetColor();

            //Total: 9 rows.

            //We have to make all the ones below to not repeat. We should be able to create a Method that can solve this problem.
            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 0);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 1);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 2);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 3);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 5);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 6);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 7);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 8);
            Console.WriteLine(ColorSpacesAndSymbol(2));
            Console.ResetColor();
        }
        public static string ColorSpacesAndSymbol(int spaces) //Amount of spaces (In this case it is here for THICKNESS
        {
            string space = "";

            for (int i = 0; i < spaces; i++)
            {
                space += " ";
            }
            return space;
        }
        public static void SetPositionAndColor(ConsoleColor color, int column, int row)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(column, row);
        }
        public static string ColorRowsAndSpaces(ConsoleColor color, int spaces, int rows) //Color and spaces, rows
        {
            Console.BackgroundColor = color;
            string row = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    row += " ";
                }
                row += "\n";
            }
            Console.Write(row);
            return row;
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