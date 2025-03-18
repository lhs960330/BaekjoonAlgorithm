using System;
using System.Collections.Generic;
using System.Linq;

namespace _14425
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/14425
        static void Main( string [] args )
        {
            // 첫 번째 줄: N (집합 S에 포함된 문자열의 개수), M (검사할 문자열의 개수)
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input [0];
            int M = input [1];

            // 집합 S를 저장하기 위한 HashSet<string>
            HashSet<string> set = new HashSet<string>();

            // N개의 문자열을 집합 S에 추가
            for ( int i = 0; i < N; i++ )
            {
                string str = Console.ReadLine();
                set.Add(str);
            }

            // 검사할 M개의 문자열에 대해 집합에 포함되는지 확인
            int answer = 0;
            for ( int i = 0; i < M; i++ )
            {
                string checkStr = Console.ReadLine();
                if ( set.Contains(checkStr) )  // 집합에 해당 문자열이 있으면
                {
                    answer++;
                }
            }

            // 결과 출력
            Console.WriteLine(answer);
        }
    }
}
