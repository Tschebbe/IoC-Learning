namespace IoC_Learning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var logger = new FileLogger();
            logger.OpenLog();
            logger.Log("Hello World!");
            logger.Log("Just another log message");
            logger.CloseLog();
        }
    }
}