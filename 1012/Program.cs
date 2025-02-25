using System;
using System.Linq;
using System.Collections.Generic;

namespace _1012
{
    internal class Program
    {
        static int M, N, K;
        static int [,] map;  // 배추밭 (x, y 기준)
        static bool [,] visited;  // 방문 체크 (x, y 기준)
        static int [] dx = { 1, -1, 0, 0 };  // 좌우 이동
        static int [] dy = { 0, 0, 1, -1 };  // 상하 이동

        static void DFS( int x, int y )
        {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((x, y));
            visited [x, y] = true;

            while ( stack.Count > 0 )
            {
                var (curX, curY) = stack.Pop();

                for ( int i = 0; i < 4; i++ )
                {
                    int nextX = curX + dx [i];
                    int nextY = curY + dy [i];

                    if ( nextX >= 0 && nextY >= 0 && nextX < M && nextY < N ) // 범위 체크
                    {
                        if ( !visited [nextX, nextY] && map [nextX, nextY] == 1 )
                        {
                            visited [nextX, nextY] = true;
                            stack.Push((nextX, nextY));
                        }
                    }
                }
            }
        }

        static void Main( string [] args )
        {
            int T = int.Parse(Console.ReadLine()); // 테스트 케이스 개수 입력

            while ( T-- > 0 )
            {
                int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                M = input [0]; // 가로 길이 (X축 크기)
                N = input [1]; // 세로 길이 (Y축 크기)
                K = input [2]; // 배추 개수

                map = new int [M, N];  // (x, y) 기준 배열
                visited = new bool [M, N];

                // 배추 위치 입력
                for ( int i = 0; i < K; i++ )
                {
                    int [] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    int x = pos [0], y = pos [1];
                    map [x, y] = 1;  // (x, y) 좌표 그대로 저장
                }

                int wormCount = 0;

                // DFS 탐색
                for ( int x = 0; x < M; x++ )  // 가로 먼저 탐색
                {
                    for ( int y = 0; y < N; y++ )  // 세로 탐색
                    {
                        if ( map [x, y] == 1 && !visited [x, y] )
                        {
                            DFS(x, y);
                            wormCount++;
                        }
                    }
                }

                Console.WriteLine(wormCount);
            }
        }
    }
}
