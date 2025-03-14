namespace _19532
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/19532
        // 연립방정식
        // ax + by = c 
        // dx + ey = f
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray() ;
            int a = input [0];
            int b = input [1];
            int c = input [2];
            int d = input [3];
            int e = input [4];
            int f = input [5];

            for(int i =-999; i <= 999;  i++)
            {
                for ( int j = -999; j <= 999; j++ )
                {
                    if ( a * i + b * j == c && d * i + e * j == f )
                        Console.Write($"{i} {j}");
                }
            }
        }
    }
}
