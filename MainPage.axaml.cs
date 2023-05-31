using System;
using System.Diagnostics;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaProject;

public partial class MainPage: Window
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void onShowTasks(object sender, RoutedEventArgs e)
    {
        ContentControl content = this.FindControl<ContentControl>("MainContent");
        content.Content = "Tasks";
    }

    private void onCreateTask(object sender, RoutedEventArgs e)
    {
        ContentControl content = this.FindControl<ContentControl>("MainContent");
        content.Content = "Create Task";
    }
    
    private void onShowAccount(object sender, RoutedEventArgs e)
    {
        ContentControl content = this.FindControl<ContentControl>("MainContent");
        content.Content = "Account";
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}