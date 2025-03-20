namespace _10816
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/10816

        static void Main( string [] args )
        {
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(sr.ReadLine());
                int [] cards = sr.ReadLine().Split().Select(int.Parse).ToArray();

                int M = int.Parse(sr.ReadLine());
                int [] queries = sr.ReadLine().Split().Select(int.Parse).ToArray();

                Dictionary<int, int> cardCount = new Dictionary<int, int>();

                foreach ( int card in cards )
                {
                    if ( cardCount.ContainsKey(card) ) // 저장되 있으면 value 값을 하나씩 올려줌
                        cardCount [card]++;
                    else // 처음이면 1로 지정
                        cardCount [card] = 1;
                }
                // 결과 저장 리스트
                List<int> result = new List<int>();

                foreach ( int query in queries )
                {
                    if ( cardCount.ContainsKey(query) )// key값이 있으면 저장
                        result.Add(cardCount [query]);
                    else// 없으면 0
                        result.Add(0);
                }
                foreach( int a in result )
                {
                    sw.Write($"{a} ");
                }
            }
        }
    }
}