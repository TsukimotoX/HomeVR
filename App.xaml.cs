namespace HomeVR;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
}

public class App : Application
{
	public App()
	{
		MainPage = new MainPage();
	}
}