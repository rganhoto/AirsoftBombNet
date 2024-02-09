using AirsoftBombNet.UI.Views;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftBombNet.UI.ViewHelpers
{
    public static class NavigationLogic
    {
        static Grid? NavigationGrid;
        internal static void Initialize(Grid navigationGrid)
        {
            NavigationGrid = navigationGrid;
        }

        public static void SetWindow(UserControl control)
        {
            if (NavigationGrid != null)
            {
                NavigationGrid.Children.Last().IsVisible = false;
                NavigationGrid.Children.Add(control);
            }
        }

        public static void GoBack()
        {
            if (NavigationGrid != null && NavigationGrid.Children.Count > 1)
            {
                NavigationGrid.Children.Remove(NavigationGrid.Children.Last());
                NavigationGrid.Children.Last().IsVisible = true;
            }
        }

    }
}
