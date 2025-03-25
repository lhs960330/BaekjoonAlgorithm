namespace _2164
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2164

        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for(int i = 1; i <= N; i++)
            {
                queue.Enqueue(i);
            }
            while(queue.Count > 1)
            {
                queue.Dequeue();
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine(queue.Dequeue());
        }
    }
}
