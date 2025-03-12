namespace _2292
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2292
        // 1층 1         육각형 : 1
        // 2층 7         육각형 : 6
        // 3층 19        육각형 : 12
        // 4층 37        육각형 : 18
        // 5층 61        육각형 : 24
        // K층 1 +6(1+2+3......(K-1))
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int K = 1;// 현재 층
            int range = 1;// 마지막 번호
            while ( N > range )
            {
                range += 6 * K;
                K++;
            }
            Console.WriteLine( K );

        }
    }
}
