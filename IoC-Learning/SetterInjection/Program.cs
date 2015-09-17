using Interfaces;
using IoC_Learning;

namespace SetterInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

            var setterInjectionLogger = new LoggingEngine();

            setterInjectionLogger.Logger = logger;
            setterInjectionLogger.Log("Setter Injection logging message");


        }
    }
}
