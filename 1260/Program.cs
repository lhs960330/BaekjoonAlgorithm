namespace _1260
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/1260
        static Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        static public void AddEdge( int a, int b )
        {
            // 숫자가 처음 나오면 리스트를 만들어서 연결되어있는 애들 저장
            if ( !adjacencyList.ContainsKey(a) )
                adjacencyList [a] = new List<int>();
            if ( !adjacencyList.ContainsKey(b) )
                adjacencyList [b] = new List<int>();

            adjacencyList [a].Add(b);
            adjacencyList [b].Add(a);

        }

        // DFS 깊이로 가는거 즉 첫 노드의 연결되어있는 애들중 가장 작은 숫자(node)를 탐색 계속 반복 해줌  
        static public void DFS( int node, HashSet<int> visited )
        {
            // 연결되어있는 거 중에 가장 작은거 다시 탐색 탐색한 숫자는 삭제해줘야됨
            // 삭제 대신 방문한 노드를 저장해두고 사용하는게 더 적절
            visited.Add(node); // 방문한 노드 저장
            Console.Write($"{node} "); // 검사한 노드 출력

            // node와 연결되어 있는 숫자를 정렬해줌
            List<int> a = adjacencyList [node];
            a.Sort();

            // 연결된 노드중 방문하지 않은 노드 찾기
            foreach ( int i in a )
            {
                // 방문한 노드가 없으면 i로 들어가 방문 하면서 다시 돈다.
                if ( !visited.Contains(i) )
                    DFS(i, visited);
            }
        }
        /*1. 첫 노드 탐색
            시작 노드는 큐에 넣고 방문 처리합니다.
            시작 노드는 바로 방문하므로 큐에서 꺼내서 처리하고, 그와 연결된 노드를 모두 큐에 추가합니다.
        2. 첫 노드에 연결된 노드 탐색
            시작 노드를 방문한 후, 큐에 저장된 노드들을 차례대로 꺼내면서 연결된 노드를 큐에 추가합니다.
            큐에 들어간 노드는 순차적으로 방문되며, 해당 노드에서 다시 연결된 모든 노드를 큐에 넣습니다.
        3. 첫 노드와 연결된 모든 노드를 탐색 후 그중 가장 작은 노드와 연결된 노드 탐색
            큐에서 꺼낸 노드에 대해, 연결된 노드들을 모두 탐색합니다.
        */

        static void BFS( int node )
        {
            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>(); // 방문한 노드 저장
            queue.Enqueue(node);// 첫 노드 큐의 저장
            visited.Add(node);

            // queue에 아무것도 안남았을 때 종료
            while ( queue.Count > 0 )
            {
                // 가장 앞에 있는 큐를 꺼내면서 현재 노드 가져오기
                int currentNode = queue.Dequeue();
                // 지금 탐색중인 노드 출력 
                Console.Write($"{currentNode} ");

                List<int> a = adjacencyList [currentNode];
                a.Sort();
                // 현재 노드와 연결된 노드들 가져오기 만약 갔던곳이였으면 제외
                foreach ( int i in a )
                {
                    if ( !visited.Contains(i) )
                    {
                        queue.Enqueue(i);
                        // 예외 처리가 끝난후 저장 
                        visited.Add(i);
                    }
                }
            }

        }

        static void Main( string [] args )
        {
            string [] firstLine = Console.ReadLine().Split();
            int N = int.Parse(firstLine [0]);
            int M = int.Parse(firstLine [1]);
            int V = int.Parse(firstLine [2]);

            for ( int i = 0; i < M; i++ )
            {
                string [] edge = Console.ReadLine().Split();
                int a = int.Parse(edge [0]);
                int b = int.Parse(edge [1]);
                AddEdge(a, b);
            }
            HashSet<int> visited = new HashSet<int>();
            DFS(V, visited);
            Console.WriteLine();
            BFS(V);
            Console.WriteLine();
        }
    }
}
