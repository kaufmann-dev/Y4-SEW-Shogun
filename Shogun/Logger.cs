using System;

namespace Shogun
{
    public class Logger
    {
        public static bool LOG_TO_CONSOLE;
        private static Logger log = new Logger();
        
        public static Logger GetInstance()
        {
            return log;
        }

        private Logger()
        {
            
        }
        
        public void Info(string info)
        {
            if (LOG_TO_CONSOLE)
            {
                Console.WriteLine(info);
            }
        }
    }
}