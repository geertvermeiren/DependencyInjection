namespace dependency_injection
{
    public class ConsoleLogger : ILogger
    {
      public void LogInfo(string message)
        {
           System.Console.WriteLine(message);

        }

      public void LogError(string message)
        {
            System.Console.WriteLine(message);

        }
        
    }
}