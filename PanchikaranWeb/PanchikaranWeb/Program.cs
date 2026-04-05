using PanchikaranWeb.Components;
using PanchikaranWeb.Data;

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Explicitly bind to HTTP only — no certificate required
    builder.WebHost.UseUrls("http://localhost:5000");

    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();

    builder.Services.AddSingleton<BookDataService>();

    var app = builder.Build();

    app.UseStaticFiles();
    app.UseAntiforgery();

    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine("=== STARTUP FAILED ===");
    Console.WriteLine(ex.ToString());
    Console.ReadLine(); // Keep window open so you can read the error
}
