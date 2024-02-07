using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;

namespace AirsoftBombNet.UI.Components
{
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();
            this.DataContext = this;
            this.btnMenu.Click += BtnMenu_Click;
        }

        private void BtnMenu_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            //menu item was pressed.
            if (this.Click != null)
                this.Click(this, e);
        }

        //event
        public event EventHandler<RoutedEventArgs> Click;


        //property declarations


        public static readonly StyledProperty<IBrush?> FillProperty =
            Rectangle.FillProperty.AddOwner<MenuItem>();


        public static readonly StyledProperty<string?> TextProperty =
            TextBlock.TextProperty.AddOwner<MenuItem>();

        public static readonly StyledProperty<IImage?> SourceProperty =
            Image.SourceProperty.AddOwner<MenuItem>();



        //property definitions
        public IBrush? Fill
        {
            get { return GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }
        public string? Text
        {
            get { return GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public IImage? Source
        {
            get { return GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }


    }
}
