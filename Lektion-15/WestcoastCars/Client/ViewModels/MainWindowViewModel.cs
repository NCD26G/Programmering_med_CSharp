using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _manufacturer = "Mercedes";

    [RelayCommand]
    private void SayHello() => Console.WriteLine("Hej på dig du!");

    private void SayGoodBye()
    {
        Console.WriteLine("");
    }
}
