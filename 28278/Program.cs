namespace _28278
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/28278
        // 스택 : 선입후출
        // 시간 초과
        // stringWriter로 시간 줄여줌
        static void Main( string [] args )
        {
            StringWriter sr = new StringWriter();
            int N = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            for ( int i = 0; i < N; i++ )
            {
                var nums = Console.ReadLine().Split();
                switch ( nums [0] )
                {
                    case "1":
                        stack.Push(nums [1]);
                        break;
                    case "2":
                        if ( stack.Count > 0 )
                            sr.WriteLineAsync(stack.Pop());
                        else
                            sr.WriteLineAsync("-1");
                        break;
                    case "3":
                        sr.WriteLineAsync($"{stack.Count}");
                        break;
                    case "4":
                        if ( stack.Count > 0 )
                            sr.WriteLineAsync("0");
                        else
                            sr.WriteLineAsync("1");
                        break;
                    case "5":
                        if ( stack.Count > 0 )
                            sr.WriteLineAsync(stack.Peek());
                        else
                            sr.WriteLineAsync("-1");
                        break;
                }
            }
           Console.WriteLine(sr.ToString());
        }
    }
}
