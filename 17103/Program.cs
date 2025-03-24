namespace _17103
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/17103
        // 시간초과 이유는?
        // 여러번 같은 계산을 하게 되어서 나오는듯?
        // 테스트 숫자에서 가장 큰 수를 알고 그 수 보다 적은 모든 숫자들의 소수를 검색할 수 있게 만들어야됨
        // 골드바흐 추측이라는 경우를 사용했다. 
        // 쉽게 설명하면 내가 정한 숫자(N) 중 소수인 경우인 i가 있고 N-i가 소수이게되면
        // 두 수의 합이 무조건 N이 되기 때문에 모든 경우의 합을 비교할 필요없이 소수인지만 확인하게 되면서 좀 더 가벼운 코드가 된다.

        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int T = int.Parse(sr.ReadLine());
                int [] nums = new int [T];
                int maxNumber = 0;
                for ( int i = 0; i < T; i++ )
                {
                    // 입력 받는 순간 가장 큰 수를 체크
                    nums [i] = int.Parse(sr.ReadLine());
                    if ( nums [i] > maxNumber )
                        maxNumber = nums [i];
                }

                bool [] isPrimes = PrimeChecker(maxNumber);
                // 각 테스트 케이스에 대해 골드바흐 파티션 계산
                foreach ( int n in nums )
                {
                    int count = 0;
                    for ( int i = 2; i <= n / 2; i++ )
                    {
                        // i와 n-i가 모두 소수인 경우, 이는 골드바흐 파티션이 된다.
                        if ( isPrimes [i] && isPrimes [n - i] )
                            count++;
                    }
                    sw.WriteLine(count);
                }
            }
        }

        static bool [] PrimeChecker( int num )
        {
            // 0도 포함이므로 +1해준다.
            bool [] isPrimes = new bool [num + 1];
            // 0과 1를 제외한 모든 자연수를 true로 초기화해준다.
            for ( int i = 2; i <= num; i++ )
                isPrimes [i] = true;

            for ( int i = 2; i * i <= num; i++ )
            {
                if ( isPrimes [i] )
                {
                    // 만약 i*i가 num보다 작으면 1,i를 가지고있는 수 이기 때문에 소수가 아니게 된다.
                    for ( int j = i * i; j <= num; j += i )
                        isPrimes [j] = false;
                }
            }

            return isPrimes;
        }
    }
}
