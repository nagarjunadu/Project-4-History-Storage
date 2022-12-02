using System.Runtime.CompilerServices;

namespace Calculator;

public partial class History : ContentPage
{
	public History()
	{
		InitializeComponent();
		BindingContext = App.historyViewModel;
	}

	

}