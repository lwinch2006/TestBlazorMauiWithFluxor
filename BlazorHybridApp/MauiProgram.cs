using Microsoft.Extensions.Logging;
using BlazorHybridApp.Data;
using BlazorHybridApp.FluxorTypes.Actions;
using Fluxor;

namespace BlazorHybridApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

		builder.Services
			.AddFluxor(options =>
			{
				options.ScanAssemblies(typeof(MauiProgram).Assembly);
				options.WithLifetime(StoreLifetime.Singleton);
			})
			.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}