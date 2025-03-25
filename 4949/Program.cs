namespace _4949
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/4949
        /*모든 왼쪽 소괄호("(")는 오른쪽 소괄호(")")와만 짝을 이뤄야 한다.
          모든 왼쪽 대괄호("[")는 오른쪽 대괄호("]")와만 짝을 이뤄야 한다.
          모든 오른쪽 괄호들은 자신과 짝을 이룰 수 있는 왼쪽 괄호가 존재한다.
          모든 괄호들의 짝은 1:1 매칭만 가능하다. 즉, 괄호 하나가 둘 이상의 괄호와 짝지어지지 않는다.
          짝을 이루는 두 괄호가 있을 때, 그 사이에 있는 문자열도 균형이 잡혀야 한다.*/

        static void Main( string [] args )
        {
            Stack<char> stack = new Stack<char>();
            StringWriter sw = new StringWriter();

            while ( true )
            {
                string input = Console.ReadLine();
                // .이면 반복 그만
                if ( input == "." )
                    break;

                if ( IsBalanced(input) )
                    sw.WriteLineAsync("yes");
                else
                    sw.WriteLineAsync("no");
            }
            Console.Write(sw.ToString());
        }
        static bool IsBalanced(string input )
        {
            Stack<char> stack = new Stack<char> ();

            foreach( char c in input )
            {
                // ( 이거나 [ 이면 stack 넣는다.
                if(c == '(' || c == '[')
                    stack.Push(c);
                else if ( c == ')' )
                {
                    // stack에 아무것도 없고나 다음이 (가 아니면 실패
                    if ( stack.Count == 0 || stack.Peek() != '(' )
                        return false; // 스택이 비어있거나 짝이 맞지 않으면 false
                    stack.Pop();
                }
                else if ( c == ']' )
                {
                   
                    if(stack.Count==0 || stack.Peek() !=  '[' )
                        return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}
