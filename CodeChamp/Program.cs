namespace CodeChamp;

public static class CodeChampServer
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}