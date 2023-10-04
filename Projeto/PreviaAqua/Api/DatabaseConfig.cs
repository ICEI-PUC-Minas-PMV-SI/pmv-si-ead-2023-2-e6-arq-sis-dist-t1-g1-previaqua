namespace Api
{
    public class DatabaseConfig
    {
		public static string? GetConnectionString(IConfiguration configuration)
		{

			return Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "QA" ? configuration["QA_CONNECTION"] : configuration["DEV_CONNECTION"];
		}

		public static string? EnvConnectionString()
		{
			var server = Environment.GetEnvironmentVariable("DB_HOST");
			var database = Environment.GetEnvironmentVariable("DB_NAME");
			var user = Environment.GetEnvironmentVariable("USER_DB");
			var password = Environment.GetEnvironmentVariable("PASS_DB");
			return $"server={server}; Port=3306;user id={user};password={password};database={database};Persist Security Info=False; Connect Timeout=300";
		}
	}
}
