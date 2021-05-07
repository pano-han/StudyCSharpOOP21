using System;

namespace IndexerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList(); //3개 짜리 배열
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1); //1~5 this[index]set
            }
            for ( int i = 0; i < list.Length; i++) // this[index]set
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
