using System.Collections.Generic;

namespace _18258
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/18258
        static void Main( string [] args )
        {
            Queue<int> queue = new Queue<int>();
            int N = int.Parse(Console.ReadLine());
            StringWriter sw = new StringWriter();
            int last = -1;
            for ( int i = 0; i < N; i++ )
            {
                string [] input = Console.ReadLine().Split().ToArray();
                if ( input [0] == "push" )
                {
                    int value = int.Parse(input [1]);
                    queue.Enqueue(int.Parse(input [1]));
                    last = value;
                }
                else if ( input [0] == "pop" )
                {
                    if ( queue.Count > 0 )
                    {
                        sw.WriteLine($"{queue.Dequeue()}");
                    }
                    else
                        sw.WriteLine("-1");
                }
                else if ( input [0] == "size" )
                    sw.WriteLine($"{queue.Count()}");
                else if ( input [0] == "empty" )
                {
                    if ( queue.Count > 0 )
                        sw.WriteLine('0');
                    else
                        sw.WriteLine('1');
                }
                else if ( input [0] == "front" )
                {
                    if ( queue.Count > 0 )
                        sw.WriteLineAsync($"{queue.Peek()}");
                    else
                        sw.WriteLine("-1");
                }
                else if ( input [0] == "back" )
                {
                    if ( queue.Count > 0 )
                    {
                        sw.WriteLine(last);
                    }
                    else
                        sw.WriteLine("-1");
                }
            }
            Console.WriteLine(sw.ToString());
        }
    }
}
