namespace _28279
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/28279
        static void Main( string [] args )
        {
            LinkedList<int> ints = new LinkedList<int>();
            int N = int.Parse(Console.ReadLine());
            StringWriter sw = new StringWriter();
            for ( int i = 0; i < N; i++ )
            {
                int [] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch ( command [0] )
                {
                    case 1:
                        ints.AddFirst(command [1]);
                        break;
                    case 2:
                        ints.AddLast(command [1]);
                        break;
                    case 3:
                        if ( ints.Count > 0 )
                        {
                            sw.WriteLine($"{ints.First.Value}");
                            ints.RemoveFirst();
                        }
                        else
                            sw.WriteLine("-1");
                        break;
                    case 4:
                        if ( ints.Count > 0 )
                        {
                            sw.WriteLine($"{ints.Last.Value}");
                            ints.RemoveLast();
                        }
                        else
                            sw.WriteLine("-1");
                        break;
                    case 5:
                        sw.WriteLine($"{ints.Count}");
                        break;
                    case 6:
                        if ( ints.Count > 0 )
                            sw.WriteLine(0);
                        else
                            sw.WriteLine(1);
                        break;
                    case 7:
                        if ( ints.Count > 0 )
                        {
                            sw.WriteLine($"{ints.First.Value}");
                        }
                        else
                            sw.WriteLine("-1");
                        break;
                    case 8:
                        if ( ints.Count > 0 )
                        {
                            sw.WriteLine($"{ints.Last.Value}");
                        }
                        else
                            sw.WriteLine("-1");
                        break;
                }
            }
            Console.Write(sw.ToString());
        }
    }
}
