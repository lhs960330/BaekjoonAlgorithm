namespace BaekjoonAlgorithm
{

    internal class Program
    {
        static void Main( string [] args )
        {
            string n;
            string p;
            n = Console.ReadLine();
            p = Console.ReadLine();
            int N;
            if ( n == null )
                return;
            if ( p == null )
                return;
            N = int.Parse(n);
            int [] P = p.Split().Select(int.Parse).ToArray();
            Array.Sort(P);

            int sum = 0;
            int total = 0;
            for ( int i = 0; i < N; i++ )
            {
                sum += P [i];
                total += sum;
            }
            Console.WriteLine(total);
        }
    }
}
