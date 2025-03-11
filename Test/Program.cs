using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int B = input [1];
            int result = 0;
           

            Console.WriteLine( result );

        }
    }
}
