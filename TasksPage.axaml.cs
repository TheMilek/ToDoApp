using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaProject;

public partial class TasksPage : UserControl
{
    public TasksPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}