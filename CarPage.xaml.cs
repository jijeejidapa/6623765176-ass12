using SQLite.MVVM.ViewModels;

namespace SQLite;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
		BindingContext = new CarsPageViewModels();
	}
}