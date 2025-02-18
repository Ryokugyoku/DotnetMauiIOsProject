using MauiApp1.View.Common;

namespace MauiApp1;

public partial class AppShell : Shell
{
	private readonly LoadingPage _loadingPage = new ();
	/// <summary>
	/// Shellのコンストラクタ
	/// </summary>
	public AppShell()
	{
		InitializeComponent();
		Navigating += OnNavigating;
		Navigated += OnNavigated;
	}
	
	/// <summary>
	/// ナビゲーション中に実行されるイベント処理
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void OnNavigating(object? sender, ShellNavigatingEventArgs e)
	{
		// ローディング画面を表示
		await DisplayLoadingScreenAsync();
	}
	
	/// <summary>
	/// ナビゲーション完了後に実行されるイベント処理
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void OnNavigated(object? sender, ShellNavigatedEventArgs e)
	{
		// ローディング画面を非表示
		await HideLoadingScreenAsync();
	}
	
	/// <summary>
	/// ナビゲーション中に表示するローディング画面を表示する処理
	/// </summary>
	private async Task DisplayLoadingScreenAsync()
	{
		await Application.Current.MainPage.Navigation.PushModalAsync(_loadingPage);
	}
	
	/// <summary>
	/// ナビゲーション完了した時の処理
	/// </summary>
	/// <returns></returns>
	private async Task HideLoadingScreenAsync()
	{
		await Application.Current.MainPage.Navigation.PopModalAsync();
	}
}
