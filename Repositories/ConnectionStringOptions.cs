namespace App.Repositories
{
    public class ConnectionStringOptions
    {
        public const string Key  = "ConnectionStrings";
        public string SQLServer { get; set; } = default!;

    }
}
