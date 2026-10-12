using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView;
    private readonly ProductsViewModel _productsView;
    private readonly CustomersViewModel _customersView;
    private readonly OrdersViewModel _ordersView;

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    // Design...
    public MainWindowViewModel() { }

    public MainWindowViewModel(
        ProductsViewModel productsViewModel,
        HomeViewModel homeViewModel,
        CustomersViewModel customersViewModel,
        OrdersViewModel ordersViewModel
        )
    {
        _productsView = productsViewModel;
        _homeView = homeViewModel;
        _customersView = customersViewModel;
        _ordersView = ordersViewModel;

        CurrentView = _homeView;
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;
    [RelayCommand]
    private void GoToProducts() => CurrentView = _productsView;
    [RelayCommand]
    private void GoToCustomers() => CurrentView = _customersView;
    [RelayCommand]
    private void GoToOrders() => CurrentView = _ordersView;
}
