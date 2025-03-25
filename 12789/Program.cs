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
                // 다음순서나 stack에 들어간 숫자가 count와 같지 않으면 넘어감
                if ( nums [i] != count || stack.Peek() != count )
                    stack.Push(nums [i]);
                else
                {
                    // stack에 다음 순서와 같으면 없애주면서 카운트를 올려줌
                    if ( stack.Peek() == count )
                        stack.Pop();
                    count++;
                }

            }
            while ( stack.Count != 0 )
            {
                if ( stack.Peek() == count )
                {
                    stack.Pop();
                    count++;
                }
                else
                    break;
            }
            if ( stack.Count == 0 )
                Console.WriteLine("Nice");
            else
                Console.WriteLine("Sad");
        }
    }
}
