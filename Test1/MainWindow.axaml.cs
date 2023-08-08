using Avalonia.Controls;
using Test1.ViewModels;

namespace Test1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}