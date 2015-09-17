using IoC_Learning;
using Interfaces;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            var constructorInjectionLogger = new LoggingEngine(logger);
            constructorInjectionLogger.Log("Constructor Injection logging message");

        }
    }
}
