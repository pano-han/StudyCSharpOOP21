using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CakeUniProject4
{
    [TestClass]
    public class 미UnitTest1
    {
        public object MyClass { get; private set; }

        //properties List
        [TestMethod("더하기 테스트")]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3, b = 5;
            var result= MyClass.Plus(a, b);

            Assert.AreEqual (8, result);

            [TestMethod]
            public void PrintTest()
            {
                MyClass myClass = new MyClass ();
                int a = 10, b = 3;
                var result myClass.Divide(a, b);
                var expexted = 3;
                Assrte.AreEual(expexted, result);
            }
        }

    }
}
