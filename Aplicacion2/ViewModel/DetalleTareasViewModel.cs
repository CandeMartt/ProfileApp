using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Aplicacion2.ViewModel
{
    [QueryProperty("Text", "Text")]

   public partial class DetalleTareasViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Atras()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
