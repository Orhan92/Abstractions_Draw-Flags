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

            VerticalColor(ConsoleColor.DarkYellow, 12, 0, 4); //Yellow, Column 12, Row 0 (first), vertical length 4
            VerticalColor(ConsoleColor.DarkYellow, 12, 5, 4); //Yellow, Column 12, Row 5 (sixth), vertical length 4
            Console.ResetColor();

        }
        public static void VerticalColor(ConsoleColor color, int column,int startRow, int numberOfRows)
        {
            Console.BackgroundColor = color;

            string spaces = "";
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.SetCursorPosition(column, startRow);
                spaces = "  ";
                Console.WriteLine(spaces);
                startRow++;
            }
        }

        public static void ColorRowsAndSpaces(ConsoleColor color, int spaces, int rows) //Color and spaces, rows
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