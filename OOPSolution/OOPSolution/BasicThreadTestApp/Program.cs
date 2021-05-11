using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSomething();
            Thread th1 = new Thread(DoSomething);
            th1.Start();
            //th1.Join(); //스레드 종료 대기.

            /*th1.Abort(); 더 이상 사용 안함. */
            th1.Interrupt(); //스레드를 WaitJoinSleep 상태일 때 중단메서드
            th1.Join();
            DoOtherthing();
        }
        
        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(1);
            }
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(1);
            }
        }
    }
}
