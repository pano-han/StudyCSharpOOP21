using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object obj = (object) a;
            int b = (int) obj;

            Console.WriteLine("a의 값 : " + a);
            Console.WriteLine("obj의 값 : " + obj);
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값 : " + obj);

            Console.WriteLine("-----");
            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); //배열이지만 사이즈를 지정하지 않음. 
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort(); //위의 데이터들을 sort하려면 타입이 모두 같아야함. 
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Reverse(); 
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100); //배열에 값 추가. 
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88); // 2번 자리에 88을 추가하라는 의미.
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5); // 5번 자리에 있는 값을 삭제하라는 의미.
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            list.Remove(88); // 88을 삭제하라는 의미.
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치값 : {index14}");

            int lstIndex14 = list.LastIndexOf(14); //﻿14가 두 번있을 경우, 마지막에 있을 경우 LastIndexOf로 찾을 수 있음.
            Console.WriteLine($"마지막 14의 위치값 : {lstIndex14}");

            Console.WriteLine($"총 갯수 {list.Count}"); //리스트 데이터 갯수 구하기.
            Console.WriteLine($"리스트 마지막 값 {list[list.Count - 1]}"); //리스트 데이터 마지막 값 구하기.
        }
    }
}
