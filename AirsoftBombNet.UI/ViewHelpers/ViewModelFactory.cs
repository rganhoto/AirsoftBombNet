using AirsoftBombNet.Core.Enums;
using AirsoftBombNet.UI.ViewModels;

namespace AirsoftBombNet.UI.ViewHelpers
{
    public static class ViewModelFactory
    {
        public static GameStartViewModel CreateGameVieWModel(GameTypeEnum gameType)
        {
            var gameViewModel = new GameStartViewModel();
            switch (gameType)
            {
                case GameTypeEnum.WarmUp:
                    gameViewModel.GameName = "Warmup";
                    gameViewModel.Description = "";
                    break;
                case GameTypeEnum.Defend:
                    gameViewModel.GameName = "Defend";
                    gameViewModel.Description = "";
                    break;
                case GameTypeEnum.Sabotage:
                    gameViewModel.GameName = "Sabotage";
                    gameViewModel.Description = "";
                    break;
                case GameTypeEnum.Domination:
                    gameViewModel.GameName = "Domination";
                    gameViewModel.Description = "";
                    break;
            }


            return gameViewModel;
        }

    }
}
