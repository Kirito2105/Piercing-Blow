using System;

namespace PiercingBlow.Commons.Utils
{
    public class Logger : SingletonBase<Logger>
    {
        public void Info(string text, params object[] obj)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Info] " + text, obj);
            Console.ResetColor();
        }

        public void Info(string text, object obj)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Info] " + text, obj);
            Console.ResetColor();
        }

        public void Info(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[Info] " + text);
            Console.ResetColor();
        }

        public void Debug(string text, params object[] obj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Debug] " + text, obj);
            Console.ResetColor();
        }

        public void Debug(string text, object obj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Debug] " + text, obj);
            Console.ResetColor();
        }

        public void Debug(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[Debug] " + text);
            Console.ResetColor();
        }

        public void Warn(string text, params object[] obj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Warn] " + text, obj);
            Console.ResetColor();
        }

        public void Warn(string text, object obj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Warn] " + text, obj);
            Console.ResetColor();
        }

        public void Warn(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Warn] " + text);
            Console.ResetColor();
        }

        public void Error(string text, params object[] obj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Error] " + text, obj);
            Console.ResetColor();
        }

        public void Error(string text, object obj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Error] " + text, obj);
            Console.ResetColor();
        }

        public void Error(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Error] " + text);
            Console.ResetColor();
        }

        public void Trace(string text)
        {
            Console.WriteLine(text);
        }
    }
}
