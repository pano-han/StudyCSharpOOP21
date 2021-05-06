using System;

namespace MakeRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            var radius = float.Parse(Console.ReadLine());
            Console.WriteLine($"원의 넓이는 {radius * radius * Math.PI}");
        }
    }
}
