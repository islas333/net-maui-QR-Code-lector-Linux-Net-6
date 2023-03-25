using ZXing.Net.Maui;

namespace MauiTest;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
	{
		Dispatcher.Dispatch(() =>
		{
			barcodeResult.Text = $"{e.Results[0].Value} {e.Results[0].Format}";
		});
	}

}

