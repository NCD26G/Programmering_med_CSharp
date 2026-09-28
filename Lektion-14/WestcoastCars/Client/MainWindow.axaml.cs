using System;
using System.Diagnostics;
using Avalonia.Controls;

namespace Client;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        Console.WriteLine("Du klickade på mig!!!");
        Debug.WriteLine("Du klickade på mig via debug!!!");
    }
}