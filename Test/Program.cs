using System.Reflection.PortableExecutable;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main( string [] args )
        {
            using ( StreamReader input = new StreamReader(Console.OpenStandardOutput()) )
            using ( StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(input.ReadLine());
                int [] count = new int [10001];

                for ( int i = 0; i < N; i++ )
                {
                    // 같은 숫자가 몇개인지
                    count [int.Parse(input.ReadLine())]++;
                }
                // 같은 숫자들을 먼저 사용
                for ( int num = 1; num <= 10000; num++ )
                {
                    for ( int j = 0; j < count [num]; j++ )
                    {
                        writer.WriteLine(num);
                    }

                }
        }
    }
}