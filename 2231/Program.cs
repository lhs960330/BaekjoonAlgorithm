namespace _2231
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2231

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 0;
            for ( int i = 0; i < N; i++ )
            {
                int a = i;
                string b = i.ToString();

                for ( int j = 0; j < b.Length; j++ )
                {
                    a += b [j] - '0';
                }
                if ( N == a )
                {
                    answer = i;
                    break;
                }

            }
            if ( answer == 0 )
                Console.WriteLine(0);
            else
                Console.WriteLine(answer);
        }
    }
}
