using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productsView = new();

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainWindowViewModel()
    {
        CurrentView = _homeView;
    }

    [RelayCommand] // GoToHomeCommand
    private void GoToHome() => CurrentView = _homeView;
    [RelayCommand] // GoToProductsCommand
    private void GoToProducts() => CurrentView = _productsView;
}
