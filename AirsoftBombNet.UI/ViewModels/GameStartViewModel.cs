using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftBombNet.UI.ViewModels
{
    public class GameStartViewModel : ReactiveObject
    {
        public string GameName { get; set; } = "Sample Game Mode";
        public string Description { get; set; } = "Sample Description";
    }
}
