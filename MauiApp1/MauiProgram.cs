using Microsoft.Extensions.Logging;

namespace MauiApp1;

/// <summary>
///		Dotnet Maui Program
///		.NET MAUIのエントリーポイントとして機能するクラス
///		主に依存関係の注入や、アプリケーションの設定を行う
/// </summary>
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
