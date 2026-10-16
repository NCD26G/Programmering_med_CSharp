using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productsView;

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; } = new();

    public MainWindowViewModel(ProductsViewModel productsViewModel)
    {
        _productsView = productsViewModel;
        GoToHome();
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;
    [RelayCommand]
    private void GoToProducts() => CurrentView = _productsView;
}
