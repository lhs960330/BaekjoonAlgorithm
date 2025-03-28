using System.Text;

namespace _1010
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/1010
        static void Main( string [] args )
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < T; i++ )
            {
                int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int N = input [0];
                int M = input [1];
                long answer = 1;
                for ( int j = 0; j < N; j++ )
                {
                    answer *= ( M - j );
                    answer /= ( j + 1 );
                }
                sb.AppendLine(answer.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
