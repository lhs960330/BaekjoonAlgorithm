namespace PerfectNumber
{
    internal class Program
    {
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int answer = 0;
            Array.Sort(input);

            answer = input [0] * input [input.Length - 1];
            Console.WriteLine(answer);
        }
    }
}