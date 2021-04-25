//  -------------------------------------------------------------------------
//  <copyright file="IStartup.cs"  author="Rajesh Thomas | iamrajthomas" >
//      Copyright (c) 2021 All Rights Reserved.
//  </copyright>
// 
//  <summary>
//       Startup For Print Numbers In Unique Ways Application
//  </summary>
//  -------------------------------------------------------------------------

namespace PrintNumbersInUniqueWays.Interface
{
    public interface IStartup
    {
        void Initiate();
        void PrintNumbers_UsingNumbersAndForLoop();
        void PrintNumbers_WithoutUsingNumbers();
        void PrintNumbers_WithoutUsingNumbers_v2();
        void PrintNumbers_WithoutLoops(int Start, int MaxLimitToPrint);
    }
}
