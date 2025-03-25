namespace _12789
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/12789
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int count = 1;
            int [] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for ( int i = 0; i < N; i++ )
            {
                // 현재 숫자가 다음 순서(count)인지 확인
                if ( nums [i] == count )
                {
                    count++; // 순서가 맞으면 count 증가
                }
                else
                {
                    stack.Push(nums [i]); // 순서가 아니면 스택에 추가
                }

                // 스택에서 순서를 처리
                while ( stack.Count > 0 && stack.Peek() == count )
                {
                    stack.Pop();
                    count++;
                }
            }
            if ( stack.Count == 0 )
                Console.WriteLine("Nice");
            else
                Console.WriteLine("Sad");
        }
    }
}
