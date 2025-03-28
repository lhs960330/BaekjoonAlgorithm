namespace _26069
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/26069

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> metChongChong = new HashSet<string>();
            for ( int i = 0; i < N; i++ )
            {
                string [] input = Console.ReadLine().Split().ToArray();
                string A = input [0];
                string B = input [1];
                if ( A == "ChongChong" || B == "ChongChong" )
                {
                    metChongChong.Add(A);
                    metChongChong.Add(B);
                }
                if ( metChongChong.Contains(A) )
                {
                    metChongChong.Add(B);
                }
                else if ( metChongChong.Contains(B))
                {
                    metChongChong.Add (A);
                }
            }
            Console.WriteLine(metChongChong.Count);
        }
    }
}
