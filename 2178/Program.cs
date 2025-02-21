using System.IO.Pipes;

namespace _2178
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2178
        static void Main( string [] args )
        {
            int [] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = a [0];
            M = a [1];
            visited = new bool [N, M];
            int [,] map = new int [N, M];
            for ( int i = 0; i < N; i++ )
            {
                string c = Console.ReadLine();
                for ( int j = 0; j < M; j++ )
                {
                    map [i, j] = c [j] - '0';
                }
            }

            Console.WriteLine(BFS(map));

        }
        /// <summary>
        /// 맵의 넓이
        /// </summary>
        static int N;
        /// <summary>
        /// 맵의 높이
        /// </summary>
        static int M;
        static bool [,] visited;
        static int [] X = { 1, 0, -1, 0 };
        static int [] Y = { 0, 1, 0, -1 };
        // 무조건 1,1에서 시작 그리고 거기서부터 깊이로 탐색
        // 1. 시작 노드에서 다음 노드까지 연결되어있나 확인후 갔다가 또 연결되어있는 노드로 간다.
        static int BFS( int [,] map )
        {
            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();

            int x = 0;
            int y = 0;

            // 탐색완료된 곳은 true로 
            visited [x, y] = true;
            // 현재 위치 큐에 넣어둠
            queue.Enqueue((x, y, 1));


            while ( true)
            {
                // 현재 위치와 거리를 가져온다.
                var (currentX, currentY, dist) = queue.Dequeue();
                // 도착했을때 예외
                if( currentX == N - 1 && 
                    currentY == M - 1 )
                    return dist;

                // 이동
                for ( int i = 0; i < 4; i++ )
                {
                    int nextX = currentX + X [i];
                    int nextY = currentY + Y [i];
                    if ( nextX >= 0 && nextY >= 0 && 
                        nextX < N && nextY < M && 
                        map [nextX, nextY] == 1 && 
                        !visited [nextX, nextY] )
                    {
                        visited [nextX, nextY] = true;
                        queue.Enqueue((nextX, nextY, dist + 1));
                    }
                }
                if ( queue.Count == 0 )
                    return -1;
            }
            return -1;
        }
    }
}
