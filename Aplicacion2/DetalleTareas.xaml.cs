using Aplicacion2.ViewModel;

namespace Aplicacion2;

public partial class DetalleTareas : ContentPage
{
	public DetalleTareas(DetalleTareasViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}