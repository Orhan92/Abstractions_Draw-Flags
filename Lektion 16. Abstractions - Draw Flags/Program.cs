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

            //SWEDISH FLAG
            ColorRowsAndSpaces(ConsoleColor.Blue, 30, 4); //4 rows of Blue
            ColorRowsAndSpaces(ConsoleColor.DarkYellow, 30, 1); //1 row of Dark yellow
            ColorRowsAndSpaces(ConsoleColor.Blue, 30, 4); //4 Rows of blue
            VerticalColor(ConsoleColor.DarkYellow, 12, 0, 4); //Yellow, Column 12, Row 0 (first), vertical length 4
            VerticalColor(ConsoleColor.DarkYellow, 12, 5, 4); //Yellow, Column 12, Row 5 (sixth), vertical length 4

            Console.WriteLine();
            //FINISH FLAG
            ColorRowsAndSpaces(ConsoleColor.White, 30, 4);
            ColorRowsAndSpaces(ConsoleColor.Blue, 30, 1);
            ColorRowsAndSpaces(ConsoleColor.White, 30, 4);
            VerticalColor(ConsoleColor.Blue, 12, 10, 4);
            VerticalColor(ConsoleColor.Blue, 12, 15, 4);

            Console.WriteLine();
            //DANISH FLAG
            ColorRowsAndSpaces(ConsoleColor.Red, 30, 4);
            ColorRowsAndSpaces(ConsoleColor.White, 30, 1);
            ColorRowsAndSpaces(ConsoleColor.Red, 30, 4);
            VerticalColor(ConsoleColor.White, 12, 20, 4);
            VerticalColor(ConsoleColor.White, 12, 25, 4);
        }
        public static void VerticalColor(ConsoleColor color, int column, int startRow, int numberOfRows)
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
            Console.ResetColor();
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
            Console.ResetColor();
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