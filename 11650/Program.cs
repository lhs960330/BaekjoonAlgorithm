namespace _11650
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/11650
        // 버블 정렬을 이용하여 해보았지만 런타임이 뜬다. 
        // 따라서 힙정렬이나 병합 정렬같이 시간 복잡도가 적은 걸 사용해보자
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());

            // 2차원 좌표를 저장할 배열 튜플 자료형 
            (int x, int y) [] points = new (int, int) [N];

            for ( int i = 0; i < N; i++ )
            {
                int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points [i] = (input [0], input [1]);
            }
            points = MergeSort(points);

            foreach ( var p in points )
            {
                Console.WriteLine($"{p.x} {p.y}");
            }

        }
        // 쪼갤수 없을때까지 반으로 나눈다.
        // 나눈거끼리 비교 후 합친다.
        // 반복
        static (int x, int y) [] MergeSort( (int x, int y) [] arr )
        {
            if ( arr.Length <= 1 )
                return arr; // 하나만 남으면 정렬이 필요없어짐

            int mid = arr.Length / 2; // 중간 지점
            var left = MergeSort(arr [..mid]);  // 왼쪽 절반 정렬
            var right = MergeSort(arr [mid..]); // 오른쪽 절반 정렬

            return Merge(left, right);
        }

        static (int x, int y) [] Merge( (int x, int y) [] left, (int x, int y) [] right )
        {
            int i = 0; // 왼쪽 튜플 검색 횟수?
            int j = 0; // 오른쪽 튜플 검색 횟수?
            int k = 0; // 결과 검색 횟수

            // 왼쪽 (0 ~ right-1) 부터 오른쪽(right + end)까지 저장
            (int x, int y) [] result = new (int, int) [left.Length + right.Length];

            while ( i < left.Length && j < right.Length )
            {
                // x 좌표가 작은 값이 먼저 오도록 정렬
                // 같으면 y비교 
                if ( left [i].x < right [j].x || ( left [i].x == right [j].x && left [i].y < right [j].y ) )
                    result [k++] = left [i++];
                else
                    result [k++] = right [j++];
            }

            // 남아있는 요소들 삽입 (왼쪽 배열에 남아있는 경우)
            while ( i < left.Length )
                result [k++] = left [i++];
            // 남아있는 요소들 삽입 (오른쪽 배열에 남아있는 경우)
            while ( j < right.Length )
                result [k++] = right [j++];

            return result;
        }
    }
}
