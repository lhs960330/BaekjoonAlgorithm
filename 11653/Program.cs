namespace _11653
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/11653

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            for ( int i = 2; i * i <= N; i++ )
            {
                while ( N % i == 0 ) // i로 나누어 떨어지는 동안 반복
                {
                    Console.WriteLine(i);
                    N /= i; // N을 i로 나누어 갱신
                }
            }
            if ( N > 1 )
                Console.WriteLine(N);
        }

    }
}
