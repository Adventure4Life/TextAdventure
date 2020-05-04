using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class StateOfGame
    {
        private bool gameIsRunning;
        public bool GameHasNotEnded() => gameIsRunning;

        public StateOfGame()
        {
            gameIsRunning = true;
        }

        public void QuitGame()
        {
            gameIsRunning = false;
        }
    }
}
