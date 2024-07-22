using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SimpleToDoList.ViewModels;
using SimpleToDoList.Views;

namespace SimpleToDoList;

public partial class App : Application
{
    // This is a reference to our MainViewModel which we use to save the list on shutdown. You can also use Dependency Injection
    // in your App.
    private readonly MainWindowViewModel _mainWindowViewModel = new MainWindowViewModel();

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = _mainWindowViewModel, // Remember to change this line to use our private reference to the MainViewModel
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
