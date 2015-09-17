using Interfaces;

namespace ConstructorInjection
{
    internal class ConstructorInjectionLogger
    {
        /// <summary>
        /// The logger
        /// </summary>
        private ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjectionLogger"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public ConstructorInjectionLogger(ILogger logger)
        {
            this.logger = logger;
        }
    }
}