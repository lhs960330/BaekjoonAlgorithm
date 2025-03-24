namespace _17103
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/17103
        // 시간초과 이유는?
        // 여러번 같은 계산을 하게 되어서 나오는듯?
        // 만약 테스트 중 가장 큰 수를 가지고 그 수에서 가지고있는 모든 소수를 검색 후 소수보다 작은 수들의 합을 체크해서 해보자
        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int T = int.Parse(sr.ReadLine());
                int [] answer = new int [T];
                for ( int i = 0; i < T; i++ )
                {
                    int num = int.Parse(sr.ReadLine());
                    // num 밑으로 소수들 다 찾기
                    List<int> primes = new List<int>();
                    for ( int j = 1; j < num; j++ )
                    {
                        if ( PrimeChecker(j) )
                            primes.Add(j);
                    }
                    // 저장한 list에서 소수중 두개의 합이 num이 나오는 경우 체크

                    answer [i] = SumChecket(num, primes);
                }
                foreach ( int a in answer )
                {
                    sw.WriteLine(a);
                }
            }
        }
        static int SumChecket( int num, List<int> primes )
        {
            int count = 0;
            for ( int i = 0; i < primes.Count; i++ )
            {
                // 같은 소수의 합이 num될때
                if ( num == primes [i] * 2 )
                    count++;
                for ( int j = i + 1; j < primes.Count; j++ )
                {
                    if ( num == primes [j] + primes [i] )
                        count++;
                }
            }
            return count;
        }
        static bool PrimeChecker( int num )
        {
            if ( num <= 1 ) return false;
            if ( num == 2 || num == 3 ) return true;
            if ( num % 2 == 0 || num % 3 == 0 ) return false;

            for ( int i = 5; i * i <= num; i += 6 )
            {
                if ( num % i == 0 || num % ( i + 2 ) == 0 )
                    return false;
            }
            return true;

        }
    }
}
