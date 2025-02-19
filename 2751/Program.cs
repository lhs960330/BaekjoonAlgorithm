using System;

namespace _2751
{
    internal class Program
    {
/*        // MergeSort 함수: 배열을 재귀적으로 나눔
        static void MergeSort( int [] array, int left, int right )
        {
            if ( left < right )
            {
                int middle = ( left + right ) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, right, middle);
            }
        }

        // Merge 함수: 정렬된 두 배열을 병합
        static void Merge( int [] array, int left, int right, int middle )
        {
            int i = left;
            int j = middle + 1;

            int [] tempArray = new int [right - left + 1];
            int k = 0;

            // 두 부분 배열 비교하여 작은 값 먼저 넣기
            while ( i <= middle && j <= right )
            {
                if ( array [i] <= array [j] )
                    tempArray [k++] = array [i++];
                else
                    tempArray [k++] = array [j++];
            }

            // 남아 있는 원소들 추가
            while ( i <= middle )
                tempArray [k++] = array [i++];
            while ( j <= right )
                tempArray [k++] = array [j++];

            // 정렬된 tempArray를 원래 배열에 복사
            for ( int I = 0; I < tempArray.Length; I++ )
                array [left + I] = tempArray [I];
        }*/

        static void Main( string [] args )
        {
            StreamReader
            int N = int.Parse(Console.ReadLine());
            int [] array = new int [N];
            
            for ( int i = 0; i < N; i++ )
            {
                array [i] = int.Parse(Console.ReadLine());
            }

            Array.Sort (array);

            for ( int i = 0;i < array.Length;i++ )
                Console.WriteLine ( array [i] );

        }
    }
}
