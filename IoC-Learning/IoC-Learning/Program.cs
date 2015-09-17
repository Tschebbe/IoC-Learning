using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new FileLogger();
            logger.OpenLog();
            logger.Log("Hello World!");
            logger.Log("Just another log message");
            logger.CloseLog();
        }
    }
}
