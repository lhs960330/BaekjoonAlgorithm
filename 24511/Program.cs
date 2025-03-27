using System.Text;

namespace _24511
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/24511
        // 실패 원인 : N이 최대 100000이고 M이 100000이기 떄문에 시간복잡도가 O(N*M)일때 최악 10억번이 실행되므로 시간초과가 걸린다.
        // 해결방안 : 스택은 사실상 그대로 이므로 queue만 사용하면 된다. 또한 여러개의 queue가 필요하지 않고
        // 하나의 queue에 저장하고 빼는 방식으로 사용하여도 방식은 같게 된다.
        static void Main( string [] args )
        {

            int N = int.Parse(Console.ReadLine()); // 자료구조의 갯수

            int [] A = Console.ReadLine().Split().Select(int.Parse).ToArray();// 수열 A i번째가 0 이면  큐, 1이면 스택

            int [] B = Console.ReadLine().Split().Select(int.Parse).ToArray();// 수열 B i번째는 원소가 들어간다.

            int M = int.Parse(Console.ReadLine()); // 수열의 길이

            int [] C = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 수열 C queuestack 삽입할 원소 

            StringBuilder sb = new StringBuilder();
            Queue<int> q = new Queue<int>();
            for ( int i = N - 1; i >= 0; i-- )
            {
                if ( A [i] == 0 )
                    q.Enqueue(B [i]);
            }
            for ( int i = 0; i < M; i++ )
            {
                q.Enqueue(C [i]);
                sb.Append(q.Dequeue() + " ");
            }
            Console.Write(sb.ToString());
        }
    }
}


