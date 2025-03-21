namespace _4948
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/4948

        static void Main( string [] args )
        {
            List<int> answer = new List<int>();
            while ( true )
            {
                int n = int.Parse(Console.ReadLine());
                if ( n == 0 )
                    break;
                int count = 0;
                for ( int i = n + 1; i <= 2 * n; i++ )
                {
                    if ( PrimeChecker(i) )
                        count++;
                }
                answer.Add(count);
            }
            foreach ( int i in answer )
            {
                Console.WriteLine(i);
            }
            
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
