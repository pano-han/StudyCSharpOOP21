using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            { list[i] = i + 1; }
            for (int i = 0; i < list.Length; i++)
            { Console.Write($"{list[i]}\t"); }
            MyList<string> strlist = new MyList<string>();
            for (int i = 0; i < strlist.Length; i++)
            { strlist[i] = "Hello_" + (i +1); }
            for (int i = 0; i <strlist.Length; i++)
            { Console.Write($"{strlist[i]}\t"); }
            MyList<object> objlist = new MyList<object>();
            objlist[0] = 111;
            objlist[1] = 3.141592f;
            objlist[2] = "Hello, World!";
        }
    }
}
