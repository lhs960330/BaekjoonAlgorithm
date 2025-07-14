namespace programmers_12909
{
    public class Solution
    {
        public bool solution( string s )
        {
            bool answer = true;
            Queue<char> queue = new Queue<char>();
            for ( int i = 0; i < s.Length; i++ )
            {
                if ( s [i] == '(' )
                {
                    queue.Enqueue(s [i]);
                }
                else if ( s [i] == ')' && queue.Count != 0 )
                    queue.Dequeue();
                else
                    answer = false;
            }
            if(queue.Count != 0 )
                answer = false;

            return answer;
        }
    }
    internal class Program
    {
        static void Main( string [] args )
        {
          Solution solution = new Solution();
           bool answer =  solution.solution(")()(");
            Console.WriteLine( answer );
        }

    }
}
