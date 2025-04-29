using CommunityToolkit.Mvvm.Input;
using SukiUIDialog.Views;
using System.Windows.Input;

namespace SukiUIDialog.ViewModels;

internal class SettingsViewModel : ViewModelBase
{
    public string Greeting => "This is my settings screen!";

    public ICommand CloseDialogCommand { get; set; }

    public SettingsViewModel()
    {
        CloseDialogCommand = new RelayCommand(CloseDialog);
    }

    private void CloseDialog()
    {
        MainWindow.DialogManager.DismissDialog();
    }
}