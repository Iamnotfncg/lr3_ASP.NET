namespace pr3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddSingleton<ICalculationService, CalculationService>();
            builder.Services.AddTransient<ITimeService, TimeService>();
            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.Run();
        }
    }
}