using System;
using System.Threading;
using System.Collections.Generic;

namespace Mindfulness
{
    public class Timer
    {
        
        private List<string> _lines = new List<string>()
            {" = >>---> ", "  = >>--->", "   = >>---", "    = >>--", "     = >>-", 
            "      = >>", "       = >", "        = ", "         =", "          ",
            "          ", "          ", ">         ", "->        ", "-->       ",
            "--->      ", ">--->     ", ">>--->    ", " >>--->   ", "= >>--->  "};

        public bool CheckHasTimePast(DateTime futureTime)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime > futureTime)
            {
                return true;
            }
            return false;
        }

        public DateTime GetFutureTime(int seconds)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(seconds);

            return futureTime;
        }
        public void Pause(int seconds)
        {

            for (int i = 0; i < seconds; i++)
            {    
                foreach (string line in _lines)
                {
                    Console.Write(line);
                    Thread.Sleep(50);
                    Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                }
            }
        }
        
        public void Pause(string message, int seconds)
        {
            Console.WriteLine($"{message}");
            
            for (int i = 0; i < seconds; i++)
            {    
                foreach (string line in _lines)
                {
                    Console.Write(line);
                    Thread.Sleep(50);
                    Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                }
            }
        }

        public void Time(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void Time(string message, int seconds)
        {
            Console.Write($"{message} {seconds}");
            Thread.Sleep(1000);

            for (int i = seconds - 1; i > 0; i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }

            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
        }
    }
}