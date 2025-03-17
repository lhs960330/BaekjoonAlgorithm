namespace _2839
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2839
        static void Main( string [] args )
        {
            int input = int.Parse(Console.ReadLine());
            int bag = -1;

            for ( int i = input / 5; i >= 0; i-- ) 
            {
                int remaining = input - ( i * 5 ); 


                if ( remaining % 3 == 0 )
                {
                    bag = i + remaining / 3;
                    break;
                }
            }

            Console.WriteLine(bag);
        }
    }
}
