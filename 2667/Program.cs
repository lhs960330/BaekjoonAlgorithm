namespace _2667
{
     class Program
    {
        // https://www.acmicpc.net/problem/2667

        static int N;
        static int [,] map;

        static bool [,] visited;

        static int [] X = { -1, 1, 0, 0 };
        static int [] Y = { 0, 0, -1, 1 };
        // DFS로 전체 탐색 하지만 붙어 있는 애들 탐색 및 저장
        static int DFS( int x, int y )
        {
            visited [x, y] = true;
            int count = 1;
            // 현재 위치에서 상하 좌우로 다 확인해 1인곳 찾아야됨

            for ( int i = 0; i < 4; i++ )
            {
                int currentX = x + X [i];
                int currentY = y + Y [i];
                // 범위 지정
                if ( currentX >= 0 && currentY >= 0 && currentX < N && currentY < N )
                {
                    // 1 일때 
                    if ( map [currentX, currentY] == 1 && !visited [currentX, currentY] )
                    {
                        count += DFS(currentX, currentY);
                    }
                }
            }
            return count;
        }
        static void Main( string [] args )
        {
            N = int.Parse(Console.ReadLine());
            map = new int [N, N];
            visited = new bool [N, N];

            // 맵 만듬
            for ( int i = 0; i < N; i++ )
            {
                string line = Console.ReadLine();
                for ( int j = 0; j < N; j++ )
                {
                    map [i, j] = line [j] - '0';
                }
            }
                List<int> units = new List<int> ();
            for ( int i = 0; i < N; i++ )
            {
                
                for ( int j = 0; j < N; j++ )
                {
                    if ( map [i, j] == 1 && !visited [i, j]  )
                    {
                        int answer = DFS(i, j);
                        units.Add (answer);
                    }
                }
                
            }
            units.Sort ();
            Console.WriteLine(units.Count);
            foreach( int i in units )
                Console.WriteLine (i);
        }
    }
}
