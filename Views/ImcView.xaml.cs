using MauiIMC.ViewModel;

namespace MauiIMC.View;

public partial class ImcView : ContentPage
{
	public ImcView()
	{
		InitializeComponent();
		BindingContext = new ImcViewModel();
	}
}
