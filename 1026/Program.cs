﻿namespace _1026
{
    internal class Program
    {
        /*문제
        옛날 옛적에 수학이 항상 큰 골칫거리였던 나라가 있었다. 이 나라의 국왕 김지민은 다음과 같은 문제를 내고 큰 상금을 걸었다.

        길이가 N인 정수 배열 A와 B가 있다. 다음과 같이 함수 S를 정의하자.

        S = A[0] × B[0] + ... + A[N-1] × B[N-1]

        S의 값을 가장 작게 만들기 위해 A의 수를 재배열하자. 단, B에 있는 수는 재배열하면 안 된다.

        S의 최솟값을 출력하는 프로그램을 작성하시오.*/
        /*입력 예시
        5
        1 1 1 6 0
        2 7 8 3 1*/
        // 결과 예시
        //18


        static void Main( string [] args )
        {
            int N = int.Parse(Console.ReadLine());
            int [] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] B = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(A);
            Array.Sort(B);
            Array.Reverse(B);
            int answer = 0;
            for(int i = 0; i < N; i++)
            {
                answer += A [i] * B [i];
            }
            Console.WriteLine(answer);
        }
    }
}
