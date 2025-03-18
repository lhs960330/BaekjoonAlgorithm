namespace _11651
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/11651
        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(sr.ReadLine());
                var Points = new List<(int x, int y)>(N);

                for ( int i = 0; i < N; i++ )
                {
                    string [] input = sr.ReadLine().Split();
                    int x = int.Parse(input [0]);
                    int y = int.Parse(input [1]);

                    Points.Add((x, y));
                }
                Points.Sort(( a, b ) => (a.y == b.y) ? a.x.CompareTo(b.x) : a.y .CompareTo(b.y));
                foreach( var point in Points )
                    sw.WriteLine($"{point.x} {point.y}");
                
            }
        }
    }
}
