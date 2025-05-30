using System;
using System.Linq;

namespace _24060
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/24060
        static int K;
        static int saveCount = 0;
        static int answer = -1;

        static void Main( string [] args )
        {
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            K = input [1];

            int [] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] tmp = new int [N];

            MergeSort(A, tmp, 0, N - 1);

           
            Console.WriteLine(answer);
        }

        static void MergeSort( int [] A, int [] tmp, int left, int right )
        {
            if ( left < right )
            {
                int mid = ( left + right ) / 2;
                MergeSort(A, tmp, left, mid);
                MergeSort(A, tmp, mid + 1, right);
                Merge(A, tmp, left, mid, right);
            }
        }

        static void Merge( int [] A, int [] tmp, int left, int mid, int right )
        {
            int i = left;
            int j = mid + 1;
            int t = 0;

            while ( i <= mid && j <= right )
            {
                if ( A [i] <= A [j] )
                    tmp [t++] = A [i++];
                else
                    tmp [t++] = A [j++];
            }

            while ( i <= mid )
                tmp [t++] = A [i++];
            while ( j <= right )
                tmp [t++] = A [j++];

            i = left; t = 0;
            while ( i <= right )
            {
                A [i] = tmp [t];
                saveCount++;
                if ( saveCount == K )
                {
                    answer = A [i];
                    return;
                }
                i++; t++;
            }
        }
    }
}
