using System.Runtime.CompilerServices;

namespace Calculator;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
		BindingContext = App.historyViewModel;
	}

	private async void Button_ClickedAsync(object sender, EventArgs e)
	{
		await App.historyViewModel.clearHistory();
	}

}