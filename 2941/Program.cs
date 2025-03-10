namespace _2941
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/2941
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            string [] input = new string [N];
            int count = 0;
            for ( int i = 0; i < N; i++ )
            {
                input [i] = Console.ReadLine();
                if ( IsGroupWord(input [i]) )
                    count++;
            }
            Console.WriteLine(count);
        }

        static bool IsGroupWord( string word )
        {
            HashSet<char> seen = new HashSet<char>();
            char prevChar = '\0'; // 이전 문자 저장

            foreach ( char c in word )
            {
                if ( c != prevChar ) // 새로운 문자가 등장했을 때
                {
                    if ( seen.Contains(c) ) // 이미 등장했던 문자가 다시 나오면 그룹 단어가 아님
                    {
                        return false;
                    }
                    seen.Add(c);
                }
                prevChar = c; // 이전 문자 업데이트
            }
            return true; // 그룹 단어라면 true 반환
        }
    }
}
