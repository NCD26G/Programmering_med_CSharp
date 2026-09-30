using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly CustomersViewModel _customersView = new();
    private readonly VehiclesViewModel _vehiclesView = new();

    [ObservableProperty]
    private ViewModelBase _currentView;
    [ObservableProperty]
    private string _manufacturer = "Mercedes";
    [ObservableProperty]
    private string model = "S500";

    public MainWindowViewModel()
    {
        _currentView = _vehiclesView;
    }
}
