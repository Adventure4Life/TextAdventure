using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    static class GameState
    {
        private static bool gameIsRunning = true;

        public static bool GameHasNotEnded()
        {
            return gameIsRunning;
        }

        public static void QuitGame()
        {
            gameIsRunning = false;
        }
    }
}
