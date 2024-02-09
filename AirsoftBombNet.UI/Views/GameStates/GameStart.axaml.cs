using AirsoftBombNet.UI.ViewHelpers;
using Avalonia.Controls;

namespace AirsoftBombNet.UI.Views.GameStates
{
    public partial class GameStart : UserControl
    {
        public GameStart()
        {
            InitializeComponent();
            btnBack.Click += BtnBack_Click;
            btnSettings.Click += BtnSettings_Click;
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }

        private void BtnSettings_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }

        private void BtnBack_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            NavigationLogic.GoBack();
        }
    }
}
