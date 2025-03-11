namespace _2563
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2563
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            // 전체 크기
            bool [,] paper = new bool [100, 100];
            for ( int i = 0; i < N; i++ )
            {
                string [] input = Console.ReadLine().Split();
                int x = int.Parse(input [0]);
                int y = int.Parse(input [1]);
                // 입력받은 x와 y에 true로 만들어서 크기 결정
                for ( int j = x; j < x + 10; j++ )
                {
                    for(int k = y; k < y + 10; k++ )
                    {
                        paper [j,k] = true;
                    }
                }
            }
            int area = 0;
            //true인곳만 계산해서 크기 만듬
            for ( int i = 0; i < 100; i++ )
            {
                for ( int j = 0; j < 100; j++ )
                {
                    if ( paper [i, j] ) area++;
                }
            }
            Console.WriteLine(area);

        }
    }
}
