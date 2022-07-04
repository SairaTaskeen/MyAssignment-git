using System;

namespace MyAssignment
{
    public class Logger : ILogger
    {
        public void log(string err)
        {
            Console.WriteLine(err);
        }
    }
}
