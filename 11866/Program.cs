namespace _11866
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/11866
        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input [0];
            int K = input [1];
            Queue<int> queue = new Queue<int>();
            StringWriter sw = new StringWriter();
            for ( int i = 1; i <= N; i++ )
            {
                queue.Enqueue(i);
            }
            int count = 1;
            Queue<int> answer = new Queue<int>();
            while ( queue.Count > 0 )
            {
                if ( count != K )
                {
                    count++;
                    queue.Enqueue(queue.Dequeue());
                }
                else
                {
                    count = 1;
                    answer.Enqueue(queue.Dequeue());
                }
            }
            Console.Write("<");
            for(int i = 0; i < N; i++ ) 
            {
                if ( answer.Count > 1 )
                    Console.Write($"{answer.Dequeue()}, ");
                else
                    Console.Write($"{answer.Dequeue()}>");
            }
        }
    }
}
