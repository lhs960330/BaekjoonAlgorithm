using System;

namespace _2581
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/2581
        // M과 N 사이에 자연수중 소수를 찾아라

        // 소수인지 아닌지 찾는 함수 
        static bool IsPrime( int num )
        {
            if ( num < 2 ) return false;
            for ( int j = 2; j * j <= num; j++ )
            {
                if ( num % j == 0 ) return false;
            }
            return true;
        }
        // M과 N 사이에 소수들 저장
        static List<int> Primes( int M, int N )
        {
            List<int> list = new List<int>();
            for ( int i = M; i <= N; i++ )
            {
                if ( IsPrime(i) )
                {
                    list.Add(i);
                }
            }
            return list;
        }
        static void Main( string [] args )
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            List<int> answer = Primes(M, N);
            if ( answer.Count == 0 )
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(answer.Sum());
                Console.WriteLine(answer.Min());
            }
        }
    }
}
