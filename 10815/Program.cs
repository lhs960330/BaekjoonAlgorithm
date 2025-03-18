using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace _10815
{
    internal class Program
    {
        //https://www.acmicpc.net/problem/10815

        static void Main( string [] args )
        {
            // StreamReader를 사용하여 입력을 빠르게 읽기
            using ( StreamReader sr = new StreamReader(Console.OpenStandardInput()) )
            using ( StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) )
            {
                int N = int.Parse(sr.ReadLine());
                // HashSet를 이용하여 빠르게 탐색 할 수있게 해줌
                HashSet<int> JeongsuCards = sr.ReadLine().Split().Select(int.Parse).ToHashSet();
                int M = int.Parse(sr.ReadLine());

                string [] cards = sr.ReadLine().Split();
                // 정답을 담을 List
                List<int> answer = new List<int>(M);

                foreach ( var a in cards )
                {
                    int number = int.Parse(a);

                    if ( JeongsuCards.Contains(number) )  // HashSet에 해당 카드가 있으면 
                    {
                        answer.Add(1);
                    }
                    else
                    {
                        answer.Add(0);
                    }
                }
                foreach ( var a in answer )
                {
                    sw.Write($"{a} ");
                }
            }
        }
    }
}
