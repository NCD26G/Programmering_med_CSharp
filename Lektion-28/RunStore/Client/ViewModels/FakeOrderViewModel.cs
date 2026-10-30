using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class FakeOrderViewModel : ViewModelBase
{
    private readonly ISalesOrdersService _salesOrderService;

    public FakeOrderViewModel()
    {
        _salesOrderService = new SalesOrderService();
        PageTitle = "Fejk Beställning";
    }

    public FakeOrderViewModel(ISalesOrdersService salesOrdersService)
    {
        _salesOrderService = salesOrdersService;
        PageTitle = "Fejk Beställning";
    }

    [RelayCommand]
    private async Task AddFakeOrder()
    {
        var customer = new Customer()
        {
            FirstName = "Michael",
            LastName = "Gustavsson",
            Email = "michael@mail.com"
        };

        var orderItems = new List<OrderItem>()
        {
            new(){Product = new(){ItemNumber="1000",Name="Gel 27", Price=1295,SupplierName="Asics"},Quantity = 1},
            new(){Product = new(){ItemNumber="1001",Name="Kompressions strumpor", Price=295,SupplierName="Puma"},Quantity = 2},
        };

        var salesOrder = new SalesOrder()
        {
            Customer = customer,
            OrderDate = DateTime.Now,
            Items = orderItems
        };

        await _salesOrderService.Add(salesOrder);
    }
}
