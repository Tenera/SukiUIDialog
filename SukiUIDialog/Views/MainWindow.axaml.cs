using SukiUI.Controls;
using SukiUI.Dialogs;

namespace SukiUIDialog.Views;

public partial class MainWindow : SukiWindow
{
    public static ISukiDialogManager DialogManager = new SukiDialogManager();

    public MainWindow()
    {
        InitializeComponent();
        DialogHost.Manager = DialogManager;
    }
}
