namespace RingMonke
{
    public class BasicVariables
    {
        private const string Version = "1.0.0";
        public const string VersionLocal = Version;
        public string LocalBlockedIDs = "";
        public string AccountID = "-";
        private protected string SessionLoginToken = "-";
        private static protected string AllowedTickets = null;

        public static string GetSessionLoginTokenProtected(string AllowedTicket)
        {
            if (AllowedTickets.Contains(AllowedTicket))
            { return "null"; }
            else return "Invalid Security Headers";
        }

        public static void DisconnectFromNetwork()
        {

        }
    }
}
