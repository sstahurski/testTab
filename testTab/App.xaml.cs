namespace testTab;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TestTabPage();  //new AppShell();
	}
}

