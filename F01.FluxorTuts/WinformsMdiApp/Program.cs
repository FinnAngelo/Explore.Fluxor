using Explore.Fluxor.FluxorTuts.Features.Counter;
using Explore.Fluxor.FluxorTuts.WinformsMdiApp.Features.Counter;
using Fluxor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Explore.Fluxor.FluxorTuts.WinformsMdiApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static async Task Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.ThreadException += (object sender, ThreadExceptionEventArgs e) => MessageBox.Show(e.Exception.Message);
        AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) => MessageBox.Show(e.ExceptionObject.ToString());

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        var store = ServiceProvider.GetRequiredService<IStore>();
        await store.InitializeAsync();

        var app = ServiceProvider.GetRequiredService<App>();
        Application.Run(app);
    }

    // hmm... is Service locator anti-pattern needed for winforms?
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddScoped<App>();
                services.AddTransient<CounterForm>();
                services.AddFluxor(o => o.ScanAssemblies(
                    typeof(Program).Assembly,
                    typeof(CounterState).Assembly
                    ));

                services.AddAutoMapper(typeof(Program).Assembly);
            });
    }
}
