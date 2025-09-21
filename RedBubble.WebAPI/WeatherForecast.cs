namespace RedBubble.WebAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
//"StoreContext": "Server=db25707.databaseasp.net; Database=db25707; User Id=db25707; Password=r@3D%5YeB-q8; Encrypt=False; MultipleActiveResultSets=True;",
// "StoreContext": "Data Source=LAPTOP-8LDLFT47\\MSSQLSERVER05;Initial Catalog=RedBubble;Integrated Security=True;TrustServerCertificate=True",

//"Redis": "localhost"