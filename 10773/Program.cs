namespace _10773
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/10773
        // 0이 나오면 그 전 숫자는 잘 못된거 나머지 다 더하기
        static void Main( string [] args )
        {
            int K = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for ( int i = 0; i < K; i++ )
            {
               int num = int.Parse(Console.ReadLine());

                if(num != 0)
                    stack.Push(num);
                else
                    stack.Pop();
            }
            Console.Write(stack.Sum());
         

        }
    }
}
