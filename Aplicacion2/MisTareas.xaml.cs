using Aplicacion2.ViewModel;

namespace Aplicacion2;

public partial class MisTareas : ContentPage
{
	public MisTareas(MisTareasViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}