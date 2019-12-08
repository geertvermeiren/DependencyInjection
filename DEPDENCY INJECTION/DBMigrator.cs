namespace dependency_injection
{
    public class DBMigrator
    {
        private ILogger _ilogger;
        public DBMigrator(ILogger ilogger)
        {
            _ilogger =ilogger;
            
        }

        public void DBMigrate()
        {
            _ilogger.LogError("logging an error at " );

            _ilogger.LogInfo("loggin an info");
        }
        
    }
}