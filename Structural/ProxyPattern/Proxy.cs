namespace DesignPattern
{
    public interface Authorization
    {
        string GetToken();
    }

    public class DBAuthorization : Authorization
    {
        public string GetToken()
        {
            return "DB-Token";
        }
    }

    public class LoggingDBAuthorization : Authorization
    {
        // This is one of the diferrent between Proxy and Decorator
        // Proxy know exactly what type of object its decorating while Decorator does not
        // Main usage of Proxy is Caching, Remote Access call, Access Restriction 
        private readonly DBAuthorization dbAuthorization = new DBAuthorization();

        public string GetToken()
        {
            var token = dbAuthorization.GetToken();
            // Log token
            return token;
        }
    }
}