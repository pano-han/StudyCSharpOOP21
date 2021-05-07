using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작!");

            int[] array = new int[5];
            try
            {
                for (int i = 0; i <= 5; i++) //예외발생 부분
                {
                    array[i] = (i + 1);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"문제발생 {ex.Message}, 관리자에게 문의하세요 : Main(16~)");
            }
            
            Console.WriteLine("다른 로직 수행");

            int[] list = { 107, 108, 109 };
            try
            {
                
                string messege = "Hello";
                Console.WriteLine(messege.Length);
                var result = list[1] / 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message} ");
                //IndexOutOfRangeException 예외시 다른 일 처리.
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("입력 좀 제발 제대로 해라.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally, 언제든지 실행됨.");
            }

            Console.WriteLine("프로그램 종료!");
        }
    }
}
