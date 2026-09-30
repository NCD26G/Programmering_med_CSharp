using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _manufacturer = "Mercedes";

    [ObservableProperty]
    private string model = "S500";

    [RelayCommand]
    private void SayHello()
    {
        Console.WriteLine("Hej på dig du!");
        Manufacturer = "Fiat";
        Model = "Uno";
    }

    private void SayGoodBye()
    {
        Console.WriteLine("");
    }
}
