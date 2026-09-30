using System;
using Avalonia.Controls;
using Client.Models;

namespace Client;

public partial class MainWindow : Window
{
    public Customer CustomerDemo { get; set; } = new Customer();

    public MainWindow()
    {
        InitializeComponent();
        FirstName.Text = CustomerDemo.FirstName;
    }

    private void Vehicle_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Klickade på visa fordon");
        Manufacturer.Text = "Mercedes";
    }

    private void Customer_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Klickade på visa kunder");
    }

    private void ChangeName_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        CustomerDemo.FirstName = FirstName.Text!;
        NewName.Text = CustomerDemo.FirstName;
        // NewName.Text = FirstName.Text;
    }
}