using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{
    private readonly ICustomerService _customerService;

    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];

    public CustomersViewModel()
    {
        _customerService = new CustomerServices();
        PageTitle = "Kund Lista";
        Init();
    }

    public CustomersViewModel(ICustomerService customerService)
    {
        _customerService = customerService;
        PageTitle = "Kund Lista";
        Init();
    }

    private async void Init()
    {
        await LoadCustomers();
    }

    private async Task LoadCustomers()
    {
        try
        {
            var customers = await _customerService.List();
            Customers = new ObservableCollection<Customer>(customers);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
