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
            this.btnSearchDestroy.Click += BtnSearchDestroy_Click;
        }

        private void BtnSearchDestroy_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnDomination_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnSabotage_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void BtnWarmup_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
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
