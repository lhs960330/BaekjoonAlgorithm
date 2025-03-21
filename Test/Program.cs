using System.Reflection.PortableExecutable;

namespace PerfectNumber
{
    internal class Program
    {
        
        static void Main( string [] args )
        {
            int T = int.Parse(Console.ReadLine());
            int [] A = new int [T];
            int [] B = new int [T];
            int [] lcm = new int [T];
            for ( int i = 0; i < T; i++ )
            {
                int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                A [i] = input [0];
                B [i] = input [1];
                lcm [i] = ( A [i] * B [i] ) / GCD(A [i], B [i]);
            }
            foreach(int i in lcm )
                Console.WriteLine(i);
        }
        static int GCD( int a, int b )
        {
            while ( b != 0 )
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}