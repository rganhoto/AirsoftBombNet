using AirsoftBombNet.Core.Enums;
using AirsoftBombNet.UI.ViewHelpers;
using AirsoftBombNet.UI.ViewModels;
using AirsoftBombNet.UI.Views.GameStates;
using Avalonia.Controls;

namespace AirsoftBombNet.UI.Views
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            this.btnSettings.Click += BtnSettings_Click;
            this.btnShutDown.Click += BtnShutDown_Click;
            this.btnWarmup.Click += BtnWarmup_Click;
            this.btnSabotage.Click += BtnSabotage_Click;
            this.btnDomination.Click += BtnDomination_Click;
            this.btnDefend.Click += BtnDefend_Click;
        }

        private void BtnDefend_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var control = new GameStart();
            control.DataContext = ViewModelFactory.CreateGameVieWModel(GameTypeEnum.Defend);
            NavigationLogic.SetWindow(control);
        }

        private void BtnDomination_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var control = new GameStart();
            control.DataContext = ViewModelFactory.CreateGameVieWModel(GameTypeEnum.Domination);
            NavigationLogic.SetWindow(control);
        }

        private void BtnSabotage_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var control = new GameStart();
            control.DataContext = ViewModelFactory.CreateGameVieWModel(GameTypeEnum.Sabotage);
            NavigationLogic.SetWindow(control);
        }

        private void BtnWarmup_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var control = new GameStart();
            control.DataContext = ViewModelFactory.CreateGameVieWModel(GameTypeEnum.WarmUp);
            NavigationLogic.SetWindow(control);
        }

        private void BtnShutDown_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            txtDiagnostic.Text = "Shutdown";
        }

        private void BtnSettings_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            txtDiagnostic.Text = "Settings";
        }
    }
}
