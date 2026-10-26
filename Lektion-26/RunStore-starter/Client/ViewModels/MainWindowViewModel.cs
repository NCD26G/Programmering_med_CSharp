using System;
using Client.Factories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly PageViewFactory _pageViewFactory;

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; } = new();

    public MainWindowViewModel(PageViewFactory pageViewFactory)
    {
        _pageViewFactory = pageViewFactory;
        GoToHome();
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _pageViewFactory.LoadPageViewModel(Enums.PageViewsEnum.Home);
    [RelayCommand]
    private void GoToProducts() => CurrentView = _pageViewFactory.LoadPageViewModel(Enums.PageViewsEnum.Products);
    [RelayCommand]
    private void GoToCustomers() => CurrentView = _pageViewFactory.LoadPageViewModel(Enums.PageViewsEnum.Customers);
    [RelayCommand]
    private void GoToAddProduct() => CurrentView = _pageViewFactory.LoadPageViewModel(Enums.PageViewsEnum.AddProduct);
    [RelayCommand]
    private void GoToEditProduct(string itemNumber) => CurrentView = _pageViewFactory.LoadPageViewModel(Enums.PageViewsEnum.EditProduct, itemNumber);
}
