using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main( string [] args )
        {

            string [] input = new string [5];
            for ( int i = 0; i < 5; i++ )
            {
                input [i] = Console.ReadLine();
            }
            string result = "";
            for ( int i = 0; i < 15; i++ )
            {
                for ( int j = 0; j < 5; j++ ) 
                {
                    if ( i < input[j].Length )
                    {
                        result += input[j] [i];
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
