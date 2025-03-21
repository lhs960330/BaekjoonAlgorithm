﻿namespace _4134
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/4134
        // 같거나 큰 소수 찾기
        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int T = int.Parse(sr.ReadLine());
                long [] answer = new long [T];
                for ( int i = 0; i < T; i++ )
                {
                    long num = long.Parse(sr.ReadLine());
                    answer [i] = NextPrime(num);
                }
                foreach ( int i in answer )
                    sw.WriteLine(i);
            }
        }
        static long NextPrime( long num )
        {
            if ( num <= 2 ) return 2; // 2는 가장 작은 소수
            if ( num % 2 == 0 ) num++; // 짝수면 홀수로 시작

            while ( !PrimeChecker(num) )
            {
                num += 2; // num은 홀수만 나오게
            }
            return num;
        }
        static bool PrimeChecker( long num )
        {
            if ( num <= 1 )
                return false; // 1 이하는 소수가 아님
            if ( num == 2 || num == 3 )
                return true; // 2와 3은 소수
            if ( num % 2 == 0 || num % 3 == 0 )
                return false; // 2와 3 으로 나누어지면 소수가 아님

            // 나머지 제외할거는 5, 7, 13같은 소수들 짝수들은 제외
            for ( int i = 5; i * i <= num; i += 6 )
            {
                if ( num % i == 0 || num % ( i + 2 ) == 0 )
                {
                    return false; //num이 i의 배수면 소수가 아니므로 false
                }
            }
            return true;
        }
    }
}
