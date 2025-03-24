namespace _13909
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/13909
        // 시간 초과
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            bool [] window = new bool [N + 1];
            // i는 몇번째 사람
            for ( int i = 1; i < window.Length; i++ )
            {
                // j 는 창문
                for ( int j = 1; i * j < window.Length; j++ )
                {
                    window [i * j] = !window [i * j];
                }
            }
            int answer = 0;
            // 어차피 window[0]은 false이기 때문에 계산에서 벗어나지 않음
            foreach ( bool i in window )
                if ( i == true )
                {
                    answer++;
                }
            Console.WriteLine(answer);
        }
    }
}
