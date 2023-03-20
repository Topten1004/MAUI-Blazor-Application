using ReDpett.Data;
using ReDpett.Modal;
using ReDpett.Service;
using SQLite;

namespace ReDpett;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        builder.Services.AddScoped(client =>
   new HttpClient
   {
       Timeout = TimeSpan.FromSeconds(15),

   });
        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        
        builder.Services.AddScoped<ListAppDataService>();

        //builder.Services.AddSingleton<AppDataService>();

        builder.Services.AddScoped<ISaveDataService, StoreDataService>();

        // Get an absolute path to the database file

        string applicationFolderPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "ReDpettApp");

        if (!Directory.Exists(applicationFolderPath))
        {
            Directory.CreateDirectory(applicationFolderPath);
        }
        string databaseFileName = Path.Combine(applicationFolderPath, "Project.json");

        if (!File.Exists(databaseFileName))
        {

            File.WriteAllLines(databaseFileName, new string[] {" "});
        }

        return builder.Build();
    }
}
