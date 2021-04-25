//  -------------------------------------------------------------------------
//  <copyright file="Startup.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Startup For Print Numbers In Unique Ways Application
//  </summary>
//  -------------------------------------------------------------------------

namespace PrintNumbersInUniqueWays.Class
{
    using PrintNumbersInUniqueWays.Interface;
    using System;

    public class Startup : IStartup
    {
        /// <summary>
        /// Responsible for All The Initial Tasks in the Application
        /// </summary>
        public void Initiate()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing These Just For Fun!! \n \n");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Printing 1 to 100 in standard way! \n");
                PrintNumbers_UsingNumbersAndForLoop();
                Console.WriteLine("============================================================== \n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Printing 1 to 100 without using any numbers or digits! (1st) \n");
                PrintNumbers_WithoutUsingNumbers();
                Console.WriteLine("============================================================== \n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Printing 1 to 100 without using any numbers or digits! (2nd) \n");
                PrintNumbers_WithoutUsingNumbers_v2();
                Console.WriteLine("============================================================== \n");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Printing 1 to 100 without using loops \n");
                PrintNumbers_WithoutLoops(1, 100);
                Console.WriteLine("============================================================== \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************** ERROR *****************************");
                Console.WriteLine("SOME ERROR OCCURRED!!");
                Console.WriteLine(ex.ToString());
                Console.WriteLine("***************************** ERROR *****************************");
                throw;
            }
        }

        /// <summary>
        /// Responsible for Printing Numbers Using Numbers And ForLoop (Standard Approach)
        /// </summary>
        public void PrintNumbers_UsingNumbersAndForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Responsible for Printing Numbers Without Using Numbers - version1.0
        /// </summary>
        public void PrintNumbers_WithoutUsingNumbers()
        {

            int StartValue = 'A' / 'A';
            string CustomeLimit = "..........";
            for (int i = StartValue; i <= CustomeLimit.Length * CustomeLimit.Length; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Responsible for Printing Numbers Without Using Numbers - version2.0
        /// </summary>
        public void PrintNumbers_WithoutUsingNumbers_v2()
        {

            int StartValue = 'A' / 'A';
            char CustomeLimit = 'd';
            for (int i = StartValue; i <= CustomeLimit; i++)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }

        /// <summary>
        ///  Responsible for Printing Numbers Without Using Loop
        /// </summary>
        /// <param name="Start"></param>
        /// <param name="MaxLimitToPrint"></param>
        /// <returns></returns> 
        public void PrintNumbers_WithoutLoops(int Start, int MaxLimitToPrint)
        {
            if(Start > MaxLimitToPrint)
            {
                Console.WriteLine();
                return;
            }
            Console.Write(Start + "  ");
            PrintNumbers_WithoutLoops(Start + 1, MaxLimitToPrint);
        }

    }
}
