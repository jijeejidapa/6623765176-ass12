using SQLite.Respositories;

namespace SQLite;

public partial class App : Application
{
	public static CarsRespository _carRepo { get; set;}
	public App(CarsRespository carsRepo)
	{
		InitializeComponent();

		_carRepo = carsRepo;

		//MainPage = new AppShell();
		MainPage = new CarPage();
		
	}
}