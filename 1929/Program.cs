namespace _1929
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/1929
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];
            List<int> answer = new List<int>();
            for ( int i = N; i <= M; i++ )
            {
                if ( PrimeChecker(i) )
                    answer.Add(i);
            }
            foreach( int i  in answer )
                Console.WriteLine(i);
        }
        static bool PrimeChecker( int num )
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
