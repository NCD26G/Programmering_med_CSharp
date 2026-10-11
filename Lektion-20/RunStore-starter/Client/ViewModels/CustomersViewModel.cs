using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomersViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];
    public CustomersViewModel()
    {
        PageTitle = "Kund Lista";
        LoadCustomers();
    }

    private void LoadCustomers()
    {
        Customers = new ObservableCollection<Customer>(CustomerServices.ListAllCustomers());
    }
}
