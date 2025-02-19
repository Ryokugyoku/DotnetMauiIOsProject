using MauiApp1.View.Common;

namespace MauiApp1;

public partial class AppShell : Shell
{
	private readonly LoadingPage _loadingPage = new();
	private bool _isNavigating = false;

	public AppShell()
	{
		InitializeComponent();
		Navigating += OnNavigating;
		Navigated += OnNavigated;
	}
	
	private async void OnNavigating(object? sender, ShellNavigatingEventArgs e)
	{
		if (!_isNavigating)
		{
			_isNavigating = true;
			await DisplayLoadingScreenAsync();
		}
	}

	private async void OnNavigated(object? sender, ShellNavigatedEventArgs e)
	{
		if (_isNavigating)
		{
			await HideLoadingScreenAsync();
			_isNavigating = false;
		}
	}

	private async Task DisplayLoadingScreenAsync()
	{
		if (Application.Current.MainPage.Navigation.ModalStack.Count == 0)
		{
			await Application.Current.MainPage.Navigation.PushModalAsync(_loadingPage);
		}
	}

	private async Task HideLoadingScreenAsync()
	{
		if (Application.Current.MainPage.Navigation.ModalStack.Count > 0)
		{
			await Application.Current.MainPage.Navigation.PopModalAsync();
		}
	}
	
}
