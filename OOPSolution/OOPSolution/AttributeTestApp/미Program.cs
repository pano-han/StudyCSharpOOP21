using System;

namespace AttributeTestApp
{
    class MyClass
    {
        //Properties
        [Obsolete("이 메서드는 폐기되었습니다. NewMethod로 대체하세요.")]
        public void OldMethod() { Console.WriteLine("뭔가를 한다."); }
        public void NewMethod() { Console.WriteLine("새로운 뭔가를 한다."); }

        public int Plus(int a, int b) { retunr}
    }
    class 미Program
    {
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            mine.OldMethod();
        }
    }
}
