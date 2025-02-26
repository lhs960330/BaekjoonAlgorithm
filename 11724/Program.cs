namespace _11724
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/11724
        static bool [] visited;
        static Queue<int> queue;
        static List<int> [] graph;
        static void DFS( int Node )
        {
            visited [Node] = true;

            foreach ( var next in graph [Node] )
            {
                if ( !visited [next] )
                {
                    DFS(next);
                }
            }
        }
        static void Main( string [] args )
        {
            int N; int M;

            int [] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = number [0];// 정점의 갯수 
            M = number [1];// 간선의 갯수
            graph = new List<int> [N + 1];
            for ( int i = 1; i <= N; i++ )
                graph [i] = new List<int>();
            for ( int i = 0; i < M; i++ )
            {
                int [] c = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int u = c [0];
                int v = c [1];
                graph [u].Add(v);
                graph [v].Add(u);
            }
            visited = new bool [N + 1];

            int count = 0;
            for ( int i = 1; i <= N; i++ )
            {
                if( !visited [i] )
                {
                    DFS (i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
