using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class SalesOrdersViewModel : ViewModelBase
{
    private readonly ISalesOrdersService _salesOrderService;

    [ObservableProperty]
    public partial ObservableCollection<SalesOrder> SalesOrders { get; set; } = [];

    public SalesOrdersViewModel()
    {
        _salesOrderService = new SalesOrderService();
        PageTitle = "Beställningar";
        Init();
    }

    public SalesOrdersViewModel(ISalesOrdersService salesOrdersService)
    {
        _salesOrderService = salesOrdersService;
        PageTitle = "Beställningar";
        Init();
    }

    private async void Init()
    {
        await LoadSalesOrders();
    }

    private async Task LoadSalesOrders()
    {
        try
        {
            var orders = await _salesOrderService.List();
            SalesOrders = new ObservableCollection<SalesOrder>(orders);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    [RelayCommand]
    private void CreateJson()
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

        List<SalesOrder> data = [salesOrder];

        var path = Environment.CurrentDirectory + "/json/salesorders.json";

        var storage = new Storage<SalesOrder>();
        storage.Write(path, data);
    }
}
