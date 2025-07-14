namespace programmers_12911
{

    public static class Solution
    {
        public static int solution( int n )
        {
            int num = n;
            int count = 0;
            string binaryNum = Convert.ToString(num, 2);
            for ( int i = 0; i < binaryNum.Length; i++ )
            {
                if ( binaryNum [i] == '1' )
                    count++;
            }

            while ( true )
            {
                num += 1;
                int count2 = 0;
                string binaryNum2 = Convert.ToString(num, 2);
                for ( int i = 0; i < binaryNum2.Length; i++ )
                {
                    if ( binaryNum2 [i] == '1' )
                        count2++;
                }
                if ( count == count2 )
                    break;
            }
            return num;
        }
    }
    internal class Program
    {
        static void Main( string [] args )
        {

            Console.Write(Solution.solution(15));
        }
    }
}
