/*
 Another great pattern. There are many ways to play with this. Great for building rules that need to enforce on some object
*/
namespace DesignPattern
{
    public enum LogLevel
    {
        None = 0,
        Info = 1,
        Debug = 2,
    }

    public interface ILogger
    {
        ILogger SetNext(ILogger nextlogger);
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
           
        }

        public ILogger SetNext(ILogger nextlogger)
        {
            return this;
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
           
        }

        public ILogger SetNext(ILogger nextlogger)
        {
            return this;
        }
    }
}