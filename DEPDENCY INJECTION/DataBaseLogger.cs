namespace dependency_injection
{
    public class DataBaseLogger:ILogger
    {
        public void LogInfo(string message)
        {
            System.Console.WriteLine(" DATABASE" +message);
        }

        public void LogError(string message)
        {
            System.Console.WriteLine("DATABASE"+message);

        }
        
    }
}