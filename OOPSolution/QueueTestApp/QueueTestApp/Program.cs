using System;
using System.Collections;

namespace QueueTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 스택큐 로직 영역 / 숨김영역

            Console.WriteLine("Queue 테스트");

            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0) ﻿//Queue는 값을 출력할 수록 값이 하나씩 빠짐. 그래서 Queue의 갯수가 0이 될 때까지 계속 반복하는 것.﻿
            {
               Console.Write(queue.Dequeue() + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Stack 테스트");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Hello");
            stack.Push(3.141592f);
            stack.Push(4);
            stack.Push(true);

            while (stack.Count > 0) ﻿ //Stack은 값을 출력할 수록 값이 하나씩 빠짐. 그래서 stack의 갯수가 0이 될 때까지 계속 반복하는 것.﻿
            {
                Console.Write($"{stack.Pop()}\t");
            }
            Console.WriteLine();
            #endregion

            #region 해쉬테이블
            Hashtable dictionary = new Hashtable();
            dictionary[1] = "책";
            dictionary[2] = "요리사";
            dictionary[3] = "지저귀다";
            dictionary[4] = "고래";

            Console.WriteLine(dictionary[3]);
            #endregion


        }
    }
}
