namespace _9012
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/9012
        // 스택을 이용한 괄호
        // 여는 괄호는 무조건 먼저 나와야함
        // stack.Push() == 여는 괄호
        // stack.Pop() == 닫는 괄호
        // 입력받는 순서대로 이런식으로 하게 되면 stack에 아무것도 없으면 완벽한 괄호 아니면 괄호가 아니다.
        static void Main( string [] args )
        {
            int T = int.Parse(Console.ReadLine());
            StringWriter sw = new StringWriter();
            for ( int i = 0; i < T; i++ )
            {
                Stack<char> stack = new Stack<char>();
                char [] chars = Console.ReadLine().ToCharArray();
                bool isValid = true;
                foreach ( char c in chars )
                {
                    if ( c == '(' )
                    {
                        stack.Push(c);
                    }
                    else if ( c == ')' )
                    {
                        if ( stack.Count > 0 && stack.Peek() == '(' )
                        {
                            // 닫는 괄호가 나오면 스택에서 여는 괄호를 제거한다.
                            stack.Pop();
                        }
                        else
                        {
                            // 스택이 비어있거나 여는 괄호가 없으면 잘못된 괄호 문자열
                            isValid = false;
                            break;
                        }
                    }
                }
                if ( isValid && stack.Count == 0 )
                {
                    sw.WriteLineAsync("YES");
                }
                else
                {
                    sw.WriteLineAsync("NO");
                }
            }
            Console.Write(sw.ToString());

        }
    }
}
