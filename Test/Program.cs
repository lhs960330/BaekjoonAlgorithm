namespace PerfectNumber
{
    internal class Program
    {
        static void Main( string [] args )
        {
            decimal n  = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine(n * n);
            if ( n * n > int.MaxValue )
                Console.WriteLine(4);
            else if( n  == 1)
                Console.WriteLine(1);
            else
                Console.WriteLine(2);
        }
    }
}