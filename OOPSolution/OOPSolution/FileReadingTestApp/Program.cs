using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //텍스트 파일에서 내용을 읽어오는 부분. 
            string fullPath = @"C:\Test\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            Console.WriteLine("텍스트 파일 읽기완료!!");

            // 텍스트 파일에서 쓰는 부분
            string writePath = @"C:\Test\HJE.txt";
            StreamWriter JE = new StreamWriter(new FileStream(writePath, FileMode.Create));
            JE.Write("Hello, World!\n");
            JE.Write("안녕하세요.\n");
            JE.Write(3.141592f);
            JE.Close(); //필수 
            Console.WriteLine("텍스트 파일 작성완료!!");


        }
    }
}
