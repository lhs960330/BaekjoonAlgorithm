namespace _1269
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/1269
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];
            int [] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> A = new HashSet<int>(N);
            HashSet<int> AB = new HashSet<int>(N);
            for ( int i = 0; i < N; i++ )
            {
                A.Add(input1 [i]);
                AB.Add(input1 [i]);
            }
            int [] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> B = new HashSet<int>(M);
            HashSet<int> BA = new HashSet<int>(M);
            for ( int i = 0; i < M; i++ )
            {
                B.Add(input2 [i]);
                BA.Add(input2 [i]);
            }
            AB.ExceptWith(B);
            BA.ExceptWith(A);
            Console.WriteLine($"{AB.Count + BA.Count}");
        }
    }
}
