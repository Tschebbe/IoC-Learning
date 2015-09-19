using Interfaces;
using IoC_Learning;

namespace ConstructorInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ILogger logger = new FileLogger();
            var constructorInjectionLogger = new LoggingEngine(logger);
            constructorInjectionLogger.Log("Constructor Injection logging message");
        }
    }
}