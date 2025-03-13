using System;
using System.Linq;

namespace PerfectNumber
{
    internal class Program
    {
        static bool IsPrime( int num )
        {
            if ( num < 2 ) return false;
            for ( int j = 2; j * j <= num; j++ )
            {
                if ( num % j == 0 ) return false; 
            }
            return true;
        }
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int [] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = num.Count(IsPrime);

            Console.Write(count);

        }
    }
}