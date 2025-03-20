namespace _11478
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/11478
        static void Main( string [] args )
        {
            string S = Console.ReadLine();
            HashSet<string> answer = new HashSet<string>(); // 해시셋을 통해 같은 요소 없애기

            for ( int i = 0; i < S.Length; i++ )
            {                
                for ( int j = i + 1; j <= S.Length; j++ )
                {
                    // 예시) S를 i(0) ~ j-i(2-0) 까지(0번째부터 2번째까지) 짜른 문자열을 answer에 넣기
                    answer.Add(S.Substring(i, j - i));
                }
            }
            Console.WriteLine( answer.Count );
        }
    }
}
