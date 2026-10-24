using CommunityToolkit.Mvvm.ComponentModel;
using SmartDesk.Context;

namespace SmartDesk.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia!";
    }
}
