using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : PageViewModel
{
    private readonly ICustomerService _customerService;

    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];

    public CustomersViewModel()
    {
        // PageTitle = "Kund Lista";
        // LoadCustomers();
    }

    public CustomersViewModel(ICustomerService customerService)
    {
        _customerService = customerService;
        PageName = Helpers.ApplicationNameEnum.Customers;
        PageTitle = "Kund Lista";
        LoadCustomers();
    }

    private void LoadCustomers()
    {
        Customers = new ObservableCollection<Customer>(_customerService.List());
    }
}
