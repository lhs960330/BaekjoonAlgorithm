namespace _10814
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/10814
        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(sr.ReadLine());

                // 나이, 이름, 들어온 순서
                var list = new List<(int age, string name, int index)>();
                for ( int i = 0; i < N; i++ )
                {
                    string [] input = sr.ReadLine().Split().ToArray();

                    list.Add((int.Parse(input [0]), input [1], i));
                }
                list.Sort(( a, b ) => a.age == b.age ? a.index.CompareTo(b.index) : a.age.CompareTo(b.age));
                foreach ( var a in list )
                {
                    sw.WriteLine($"{a.age} {a.name}");
                }
            }
        }
       
    }
}
