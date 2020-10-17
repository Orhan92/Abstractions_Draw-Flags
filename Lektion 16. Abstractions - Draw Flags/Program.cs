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
            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 0, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 1, 2); //Color, Column, Row, Thickness

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 2, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 3, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 5, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 6, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 7, 2);

            SetPositionAndColor(ConsoleColor.DarkYellow, 12, 8, 2);
            Console.ResetColor(); //We only use this once because in all the lines above we just use one color. No need to reset until here.
        }

        public static void SetPositionAndColor(ConsoleColor color, int column, int row, int spaceThickness)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(column, row);
            string space = "";

            for (int i = 0; i < spaceThickness; i++)
            {
                space += " ";
            }
            Console.WriteLine(space);
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