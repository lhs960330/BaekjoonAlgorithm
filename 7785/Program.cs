namespace _7785
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/7785
        static void Main( string [] args )
        {
            int n = int.Parse( Console.ReadLine() );
            Dictionary<string, string> entryLog = new Dictionary<string, string>();
            for ( int i = 0; i < n; i++ )
            {
                string [] input = Console.ReadLine().Split().ToArray();
                if ( entryLog.ContainsKey(input [0]) )
                {
                    entryLog [input [0]] = input [1];
                }
                else
                {
                    entryLog.Add(input [0], input [1]);
                }
            }
            foreach ( string key in entryLog.Keys )
            {
                Console.WriteLine( key );
            }
        }
    }
}
