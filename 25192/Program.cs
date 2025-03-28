namespace _25192
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/25192
        static void Main( string [] args )
        {
           
            int N = int.Parse(Console.ReadLine());
            HashSet<string> nameList = new HashSet<string>();
            int answer = 0;
            for ( int i = 0; i < N; i++ )
            {
                string input = Console.ReadLine();
                // 새로운 사람이 들어오면 리스트 초기화
                if ( input == "ENTER" )
                    nameList.Clear();

                // 리스트에 없다면 아직 인사하지 않은 사람
                if ( !nameList.Contains(input) )
                {
                    // ENTER는 이름이 아니니 걸러서 리스트에 넣어줌
                    if ( input != "ENTER" )
                    {
                        answer++;
                        nameList.Add(input);
                    }
                }

            }
            Console.WriteLine(answer);
        }
    }
}
