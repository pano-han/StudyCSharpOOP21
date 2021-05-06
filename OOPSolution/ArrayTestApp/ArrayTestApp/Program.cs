using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");

            //초기화
            //int[] scores = new int[5] { 80, 74, 81, 94, 100 };
            int[] scores = { 80, 74, 81, 94, 100 }; //이게 최종적으로 제일 짧은 코드.
            /*scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 94;
            scores[4] = 100;*/

            //학생 수학점수 총합
            int sum = 0;
            /*for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }*/
            foreach (var item in scores)
            {
                sum += item;
            }

            //평균
            float average = (float) sum / scores.Length;
            //Length는 배열에서 개체들의 갯수를 카운트해주는 역할?

            Console.WriteLine($"수학점수 총합 : {sum}, 평균 : {average}");

        }
    }
}
