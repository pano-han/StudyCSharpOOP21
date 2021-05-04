using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다.");

            //ConsoleLogger logger = new ConsoleLogger();
            ILogger logger = new ConsoleLogger(); //ILogger와 ConsoleLogger가 다른데 오류가 안 나는지. 형변환이 되기 때문.
            logger.writeLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메시지!!!!!");

            ILogger clmLogger = new FileLogger(); //ver 1.0 ClimateLogger --> 1.2 FileLogger 변경. 
            clmLogger.writeLog("맑음");
            clmLogger.WriteError("문제발생!");

            ILogger logger2 = new ClimateLogger();
            clmLogger.writeLog("흐림//");
            clmLogger.WriteError("!!!!!");
            
        }
    }
}
