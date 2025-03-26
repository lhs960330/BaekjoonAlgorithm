namespace _24511
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/24511
        // 실패 원인 : N이 최대 100000이고 M이 100000이기 떄문에 시간복잡도가 O(N*M)일때 최악 10억번이 실행되므로 시간초과가 걸린다.
        // 해결방안 : 이중 for문을 사용하지 말고 리스트에 queue와 stack를 저장하여 해보자
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine()); // 자료구조의 갯수

            int [] A = Console.ReadLine().Split().Select(int.Parse).ToArray();// 수열 A i번째가 0 이면  큐, 1이면 스택

            int [] B = Console.ReadLine().Split().Select(int.Parse).ToArray();// 수열 B i번째는 원소가 들어간다.

            int M = int.Parse(Console.ReadLine()); // 수열의 길이

            int [] C = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 수열 C queuestack 삽입할 원소 

            int [] answer = new int [M];
            int c = C [0];
            // 삽입할 원소
            for ( int i = 0; i < M; i++ )
            {

                // 수열 A, B
                for ( int j = 0; j < N; j++ )
                {
                    var queuestack = Queuestack(A [j], B [j], c);
                    B [j] = queuestack.save;
                    c = queuestack.output;
                }
                answer [i] = c;
            }

            foreach ( int i in answer )
                Console.Write($"{i} ");

        }
        static (int save, int output) Queuestack( int A, int B, int C )
        {
            if ( A == 0 )
            {
                return (C, B);
            }
            else
            {
                return (B, C);
            }
        }
    }
}
