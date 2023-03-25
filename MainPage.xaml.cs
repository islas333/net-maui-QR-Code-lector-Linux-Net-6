using ZXing.Net.Maui;

namespace MauiTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnVentanaModal(object sender, EventArgs e)
	{
		DisplayAlert("Hello", "word", "Ok");
	}

	private async void OnNewPage2(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("NewPage2");
	}

}

