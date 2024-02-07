using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftBombNet.Data.Entities
{
    public class GameSettings
    {
        public DominationGameSettings Domination { get; set; } = new DominationGameSettings();
        public SabotageGameSettings Sabotage { get; set; } = new SabotageGameSettings();
        public SearchAndDestroyGameSettings SearchAndDestroy { get; set; } = new SearchAndDestroyGameSettings();
        public WarmupGameSettings Warmup { get; set; } = new WarmupGameSettings();
        public GeneralSettings Settings { get; set; } = new GeneralSettings();
    }
}
