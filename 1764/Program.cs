namespace _1764
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/1764
        static void Main( string [] args )
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];

            HashSet<string> names = new HashSet<string> (N);
            List<string> answer =new List<string> ();
            for (int i = 0; i < N; i++)
            {
                names.Add(Console.ReadLine());
            }
            for(int i = 0;i < M; i++)
            {
                string name = Console.ReadLine();
                if ( names.Contains(name) )
                {
                    answer.Add (name);
                }
            }
            Console.WriteLine(answer.Count);
            answer.Sort ();
            foreach(string name in answer)
            {
               
                Console.WriteLine (name);
            }
        }
    }
}
