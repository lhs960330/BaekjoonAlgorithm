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
            foreach(int  i in a )
            {
                // 방문한 노드가 없으면 i로 들어가 방문 하면서 다시 돈다.
                if ( !visited.Contains(i) ) 
                DFS(i, visited );
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
            DFS(V,visited);
        }
    }
}
