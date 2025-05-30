namespace _4779
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/4779
        static void Main( string [] args )
        {
            string line;
            while ( ( line = Console.ReadLine() ) != null && line != "" )
            {
                int N = int.Parse(line);
                int size = ( int )Math.Pow(3, N);
                char [] result = new char [size];
                for ( int i = 0; i < size; i++ )
                    result [i] = '-';

                Cantor(result, 0, size);

                Console.WriteLine(new string(result));
            }
            static void Cantor( char [] arr, int start, int Lenght )
            {
                if ( Lenght < 3 )
                    return;

                int third = Lenght / 3;
                for ( int i = start + third; i < start + 2 * third; i++ )
                    arr [i] = ' ';

                Cantor(arr, start, third);
                Cantor(arr, start + 2 * third, third);
            }
        }
    }
}