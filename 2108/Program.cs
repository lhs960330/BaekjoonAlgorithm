namespace _2108
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/2108
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int [] array = new int [N];
            int [] frequency = new int [8001]; // -4000 ~ 4000을 저장할 배열

            int sum = 0;
            for ( int i = 0; i < N; i++ )
            {
                array [i] = int.Parse(Console.ReadLine());
                sum += array [i];
                frequency [array [i] + 4000]++; // 음수 처리 위해 +4000
            }

            int median = 0;
            int range = 0;

            // 평균
            int average = ( int )Math.Round(( double )sum / N);


            // 중앙값
            Array.Sort(array);
            median = array [( N / 2 )];

            // 최빈값
            int maxFreq = frequency.Max();
            List<int> modes = new List<int>();
            for ( int i = 0; i < 8001; i++ )
            {
                if ( frequency [i] == maxFreq )
                    modes.Add(i - 4000); // 다시 원래 값으로 변환
            }
            modes.Sort(); // 여러 개일 경우 정렬
            int mode = 0;
            // 두 번째로 작은 최빈값 선택
            if ( modes.Count > 1 )
                mode = modes [1];
            else 
                mode = modes [0];

            // 범위
            range = array.Max() - array.Min();

            Console.WriteLine(average);
            Console.WriteLine(median);
            Console.WriteLine(mode);
            Console.WriteLine(range);
        }
    }
}
