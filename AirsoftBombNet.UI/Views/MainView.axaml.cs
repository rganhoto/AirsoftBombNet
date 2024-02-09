using AirsoftBombNet.UI.ViewHelpers;
using Avalonia.Controls;

namespace AirsoftBombNet.UI.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        NavigationLogic.Initialize(navigationGrid);
    }
}
