using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiAppICommandProblem;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FontAwesomeSolid900.otf", "FontAwesome");
                fonts.AddFont("fa-solid-900.ttf", "FASolid900");
            });


		builder.Services.AddTransient<MainPage, MainViewModel>();
		builder.Services.AddTransientWithShellRoute<TestPage, TestViewModel>(nameof(TestPage));

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
