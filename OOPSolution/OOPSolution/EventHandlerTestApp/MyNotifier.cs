using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message); //대리자 선언
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            if (number / 10 == 3 || number / 10 == 6 || number / 10 == 9||
                number % 10 == 3 || number % 10 == 6 || number % 10 == 9) //3, 6, 9
            {
                SomethingHappened($"짝!\t");
            }
            else
            {
                SomethingHappened($"{number}\t");
            }
        }
    }
}
