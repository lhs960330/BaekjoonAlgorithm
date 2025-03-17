namespace _10989
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/10989
        // 최적화를 위해 console.Write와 console.Read같은 입출력대신 Stream를사용
        static void Main( string [] args )
        {
            using ( StreamReader reader = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(reader.ReadLine());

                // 주어진 10,000보다 작기 때문에 크기를 int[0] ~ int[10000] 까지 만들어줌
                int [] count = new int [10001];
                for ( int i = 0; i < N; i++ )
                {
                    // 같은 숫자 만큼 count를 올려준다.
                    count [int.Parse(reader.ReadLine())]++;
                }
                // 1부터 ~ 10,000까지 다 돌아본다.
                for ( int nums = 1; nums < count.Length; nums++ )
                    // 한개 이상 있으면 출력
                    for ( int i = 0; i < count [nums]; i++ )
                        writer.WriteLine(nums);
            }
        }
    }
}
