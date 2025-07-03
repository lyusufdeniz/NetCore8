namespace App.Repositories
{
    public class ConnectionStringOptions
    {
        public const string Key  = "ConnectionString";
        public string SQLServer { get; set; } = default!;

    }
}
