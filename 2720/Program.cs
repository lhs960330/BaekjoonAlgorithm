namespace _2720
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/2720
        static void Main( string [] args )
        {
            int T = int.Parse(Console.ReadLine());
            int Quarter = 25;
            int Dime = 10;
            int Nickel = 5;
            int Penny = 1;
            int [,] balance = new int [T, 4];
            for ( int i = 0; i < T; i++ )
            {
                int change = int.Parse(Console.ReadLine());
                if ( change >= Quarter )
                {
                    balance [i, 0] = change / Quarter;
                    change -= Quarter * balance [i, 0];
                }
                if ( change >= Dime )
                {
                    balance [i, 1] = change / Dime;
                    change -= Dime * balance [i, 1];
                }
                if ( change >= Nickel )
                {
                    balance [i, 2] = change / Nickel;
                    change -= Nickel * balance [i, 2];
                }
                if ( change >= Penny )
                {
                    balance [i, 3] = change / Penny;
                    change -= Penny * balance [i, 3];
                }
            }
            for ( int i = 0; i < T; i++ )
            {
                for ( int j = 0; j < 4; j++ )
                {
                    Console.Write($"{balance [i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
