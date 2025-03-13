namespace _2798
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2798
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];
            int [] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int current = 0;
            for ( int i = 0; i < N; i++ )
            {
                int sum = 0;
                for ( int j = i+1; j < N; j++ )
                {
                    for ( int k = j+1; k < N; k++ )
                    {
                        sum = num [i] + num [j] + num [k];
                        if ( M >= sum && current < sum )
                            current = sum;

                    }
                }
            }
            Console.WriteLine(current);
        }
    }
}
