using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); //계산 대리자 선언
    class Program
    {
        static void Main(string[] args)
        {
            #region
            FireStation Station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(Station.Call119);
            fireHouse += new ThereIsAFire(Station.ShotOut);
            fireHouse += new ThereIsAFire(Station.Escape);
            //대리자 실행
            fireHouse("학교");
            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(Station.Call119);
            fireWoorim += new ThereIsAFire(Station.Escape);
            //대리자 실행
            fireWoorim("우림라이온 밸리 A");
            #endregion

            Calculate calc;
            //무명함수를 표현한 방법 1 = 일반식
            /*calc = delegate (int a, int b)
            {
                return a + b;
            };*/
            //무명함수 표현 2 = 람다식
            calc = (a, b) => a + b;
            Console.WriteLine($"a + b = {calc(3, 5)}");
        }
    }
}
