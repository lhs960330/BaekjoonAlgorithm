using System;

namespace _1436
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/1436

        static void Main( string [] args )
        {
            int input = int.Parse(Console.ReadLine());

            int count = 0;
            string answer= "-1";
            for ( int i = 0; i < int.MaxValue; i++ )
            {
                string num = i.ToString();
                if ( num.Contains("666") )
                {
                    answer = num;  
                    count++;
                }
                if ( count == input )
                    break;
            }
            Console.WriteLine(answer);
        }
    }
}
