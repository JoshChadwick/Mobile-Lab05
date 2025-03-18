using Microsoft.Extensions.Logging;
using MonkeyFinder.View;
using MonkeyFinder.Services;		
namespace MonkeyFinder;

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

#if DEBUG
        //We are registering the MonkeyService and MonkeysViewModel as singletons.This means they
        //will only be created once, if we wanted a unique instance to be created each request we
        //would register them as Transient.
        builder.Services.AddSingleton<MonkeyService>();
        builder.Services.AddSingleton<MonkeysViewModel>();
        builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
