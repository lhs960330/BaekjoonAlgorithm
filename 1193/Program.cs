namespace _1193
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/1193
        // 1개 1,1               1   
        // 2개 2,1 1,2           2~3 
        // 3개 3,1 2,2 1,3       4~6 
        // 4개 4,1 3,2 2,3 1,4   7~10
        // N이 어디에 속하는 먼저 찾자
        // 대각선의 갯수를 K라고 했을 때 
        // K는 1+2+3...K = 마지막 번호
        // 1+2+3... (K-1)+1 = 시작번호
        // N은 이 사이에 있음
        // 또한 x는 K  y는 1부터 시작하는 층(K) 에 있음
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int K = 1; // 시작 층
            int lastNum = 1; // 마지막번호
            while(lastNum < N )
            {
                K++;
                lastNum += K;
            }

            int x, y;

            if()

        }
    }
}
