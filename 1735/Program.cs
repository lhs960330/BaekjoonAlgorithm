namespace _1735
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/1735
        static void Main( string [] args )
        {

            int [] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int [] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // A은 분자
            int [] A = new int [2];
            A [0] = input1 [0];
            A [1] = input2 [0];
            // B은 분모
            int [] B = new int [2];
            B [0] = input1 [1];
            B [1] = input2 [1];

            // 최소공배수를 구하여 공통 분모를 계산
            int lcm = ( B [0] * B [1] ) / GCD(B [0],B [1]);
            // 분자를 변환 후 더함
            int num = ( A[0] * ( lcm / B [0] ) ) + ( A[1]* ( lcm / B [1] ) );
            int den = lcm;

            // 결과를 기약분수로 변환
            int resultGCD = GCD(num, den);
            num /= resultGCD;
            den /= resultGCD;
            Console.Write($"{num} {den}");
        }

        static int GCD( int a, int b )
        {
            while ( b != 0 )
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
