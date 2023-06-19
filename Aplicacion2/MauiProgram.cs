using Aplicacion2.ViewModel;

namespace Aplicacion2;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


        builder.Services.AddSingleton<MisTareas>();
        builder.Services.AddSingleton<MisTareasViewModel>();

        builder.Services.AddTransient<DetalleTareas>();
        builder.Services.AddTransient<DetalleTareasViewModel>();
        return builder.Build();
	}
}
