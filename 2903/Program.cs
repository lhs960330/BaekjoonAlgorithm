namespace _2903
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2903
        // 초기 상태는 점 4개인상태       변 1*1
        // 1번 이동후면 한 변당 3개 점 즉 변 3*3
        // 2번 이동후면 한 변당 5개 점 즉 변 5*5
        // 3번 이동후면 한 변당 9개 점 즉 변 9*9
        // 한 변당 점의 갯수는 (전 한 변당 점의 갯수)*2-1
        // 총 점의 갯수는 한변의 점의 갯수 제곱
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            // 초기 한변의 점 갯수
            int L = 2;
            
            for(int i= 0; i < N; i++)
            {
                L = L * 2 - 1;
            }
            Console.WriteLine( L *L);
        }

    }
}
