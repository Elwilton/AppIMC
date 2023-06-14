using MauiIMC.View;

namespace MauiIMC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ImcView());
	}
}

