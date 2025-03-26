namespace _2346
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/2346
        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            // 현 위치와 이동해야되는곳을 같이 저장
            LinkedList<(int index, int move)> balloons = new LinkedList<(int index, int move)>();
            int [] moves = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for ( int i = 0; i < N; i++ )
            {
                // 차례대로넣어야됨
                balloons.AddLast((i + 1, moves [i]));
            }
            // 스타트는 1번째 인덱스에서부터 시작
            var curNode = balloons.First;
            // 지나간 인덱스는 여기에 저장
            List<int> answer = new List<int>();
            while ( balloons.Count > 0 )
            {
                // 현재 풍선 위치 저장
                answer.Add(curNode.Value.index);

                // 움직여야될 index
                int move = curNode.Value.move;

                if ( balloons.Count == 1 )
                    break;

                
                // 다음 위치 저장 
                var nextNode = curNode;
                
                // move만큼 반복적으로 움직여줌
                if ( move > 0 ) // move 양수일때
                {
                    // 현재 위치 풍선 제거
                    if ( nextNode.Next != null )
                    {
                        nextNode = nextNode.Next;
                        balloons.Remove(curNode);
                    }
                    else
                    {
                        nextNode = balloons.First;
                        balloons.Remove(curNode);
                    }
                    for ( int i = 0; i < move - 1; i++ )
                    {
                        // 노드의 마지막이면 첫 노드로 지정
                        if ( nextNode.Next != null )
                            nextNode = nextNode.Next;
                        else
                            nextNode = balloons.First;

                    }
                }
                else// move가 음수일때
                {
                    // 현재 위치 풍선 제거
                    if ( nextNode.Previous != null )
                    {
                        nextNode = nextNode.Previous;
                        balloons.Remove(curNode);
                    }
                    else
                    {
                        nextNode = balloons.Last;
                        balloons.Remove(curNode);
                    }
                    for ( int i = 0; i < Math.Abs(move) - 1; i++ )
                    {
                        // next노드가 처음이면 마지막 노드로 지정
                        if ( nextNode.Previous != null )
                            nextNode = nextNode.Previous;
                        else
                            nextNode = balloons.Last;
                    }
                }
                curNode = nextNode;
            }
            foreach ( int i in answer )
                Console.Write($"{i} ");
        }
    }
}