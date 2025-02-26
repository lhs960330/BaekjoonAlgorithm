using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _11725
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/11725
        static List<int> [] tree;
        static int [] parent;
        static bool [] visited;

        static int DFS( int node )
        {
            visited [node] = true;

            foreach ( int next in tree [node] )
            {
                if ( parent [next] == 0 )
                {
                    parent [next] = node; // 부모 기록
                    return next;
                }
            }
            return 0;
        }

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            tree = new List<int> [N + 1]; // 1-based index 사용
            parent = new int [N + 1];
            visited = new bool [N + 1];

            for ( int i = 1; i <= N; i++ )
                tree [i] = new List<int>();

            for ( int i = 1; i < N; i++ )
            {
                int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input [0];
                int b = input [1];

                tree [a].Add(b);
                tree [b].Add(a);
            }


            for ( int i = 2; i <= N; i++ )
            {
                Console.WriteLine(DFS(i)); // 2번 노드부터 부모 출력
            }
        }
    }
}
