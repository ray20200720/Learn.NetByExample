using AppLogger;

namespace TestMyAppLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var logger = new Logger();
            logger.Log("Hello");
        }
    }
}