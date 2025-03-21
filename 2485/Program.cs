using System;

namespace _2485
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/2485

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int [] tree = new int [N];
            for ( int i = 0; i < N; i++ )
            {
                tree [i] = int.Parse(Console.ReadLine());
            }

            int [] gaps = new int [N - 1];
            for ( int i = 0; i < N - 1; i++ )
            {
                gaps [i] = tree [i + 1] - tree [i];
            }

            // 모든 간격의 GCD 계산
            int gcd = gaps [0];
            for ( int i = 1; i < gaps.Length; i++ )
            {
                gcd = GCD(gcd, gaps [i]);
            }

            // 필요한 추가 가로수 계산
            int totalTreesNeeded = 0;
            foreach ( int gap in gaps )
            {
                totalTreesNeeded += ( gap / gcd ) - 1;
            }

            Console.WriteLine(totalTreesNeeded);

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
