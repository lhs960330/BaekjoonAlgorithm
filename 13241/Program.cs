using System.Runtime.InteropServices;

namespace _13241
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/13241
        // 최대공배수 = 두수의 곱/최대공약수
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long A = input [0];
            long B = input [1];

            long LCM = ( A * B ) / GCD(A, B);
            Console.WriteLine(LCM);
        }
        // 최대 공약수
        static long GCD( long a, long b )
        {
            while ( b != 0 )
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
