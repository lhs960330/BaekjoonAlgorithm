namespace _25206
{
    internal class Program
    {
        // https://www.acmicpc.net/problem/25206
        static void Main( string [] args )
        {
            Dictionary<string, float> grades = new Dictionary<string, float>();
            float [] subjectGrade = new float [20];
            grades.Add("A+", 4.5f);
            grades.Add("A0", 4f);
            grades.Add("B+", 3.5f);
            grades.Add("B0", 3f);
            grades.Add("C+", 2.5f);
            grades.Add("C0", 2f);
            grades.Add("D+", 1.5f);
            grades.Add("D0", 1f);
            grades.Add("F", 0);

            float totalCredits = 0;
            float weightedGradeSum = 0;

            for ( int i = 0; i < 20; i++ )
            {
                string [] input = Console.ReadLine().Split();
                float credit = float.Parse(input [1]);
                string grade = input [2];

                // P 과목은 제외
                if ( grade != "P" )
                {
                    weightedGradeSum += credit * grades [grade];
                    totalCredits += credit;
                }
            }

            // 전공 평점 계산
            float majorGPA = weightedGradeSum / totalCredits;
            Console.WriteLine($"{majorGPA:F4}");
        }
    }
}
