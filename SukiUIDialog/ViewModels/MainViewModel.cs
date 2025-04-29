using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using SukiUI.Dialogs;
using SukiUIDialog.Views;

namespace SukiUIDialog.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public ICommand OpenDialogCommand { get; set; }

    public MainViewModel()
    {
        OpenDialogCommand = new RelayCommand(OpenDialog);
    }

    private void OpenDialog()
    {
        MainWindow.DialogManager.CreateDialog()
            .WithViewModel(x => new SettingsViewModel(x))
            .Dismiss().ByClickingBackground()
            .TryShow();
    }
}
