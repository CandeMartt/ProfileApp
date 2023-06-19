namespace Aplicacion2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(DetalleTareas), typeof(DetalleTareas));
	}
}
