using System;

namespace _1018
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/1018
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];

            char [,] chess = new char [N, M];

            for ( int i = 0; i < N; i++ )
            {
                char [] input2 = Console.ReadLine().ToCharArray();

                for ( int j = 0; j < M; j++ )
                {
                    chess [i, j] = input2 [j];
                }
            }
            int min = int.MaxValue;

            for ( int i = 0; i <= N - 8; i++ )
            {
                int count = 0;
                for ( int j = 0; j <= M - 8; j++ )
                {
                    int startW = 0; // 'W' 시작 체스판과 비교
                    int startB = 0; // 'B' 시작 체스판과 비교

                    for ( int x = 0; x < 8; x++ )
                    {
                        for ( int y = 0; y < 8; y++ )
                        {
                            // 짝수인 경우
                            if ( ( x + y ) % 2 == 0 )
                            {
                                if ( chess [i + x, j + y] != 'W' )// 짝수들이 W여야 되는 경우
                                    startW++;
                                if ( chess [i + x, j + y] != 'B' )// 반대 경우
                                    startB++;
                            }
                            // 홀수인 경우
                            else
                            {
                                if ( chess [i + x, j + y] != 'B' )// 홀수들이 B여야 되는 경우
                                    startW++;
                                if ( chess [i + x, j + y] != 'W' )
                                    startB++;
                            }
                        }

                    }
                    min = Math.Min(min, Math.Min(startW, startB));
                }
            }
            Console.WriteLine(min);
        }
    }
}
