using Interfaces;

namespace ConstructorInjection
{
    internal class ConstructorInjectionLogger
    {
        private ILogger logger;

        public ConstructorInjectionLogger(ILogger logger)
        {
            this.logger = logger;
        }
    }
}