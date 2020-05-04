using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class GameEngine
    {
        private CommandProcessor.InputUtils PlayerInput;
        private DataReader.FilePaths Paths;
        private StateOfGame GameState;
        private Dictionary<string, string> CMD_Singles;
        #region Constructor
        public GameEngine()
        {
            PlayerInput = new CommandProcessor.InputUtils();
            Paths = new DataReader.FilePaths();
            GameState = new StateOfGame();
            CMD_Singles = new Dictionary<string, string>();
            DataReader.ListProcessor LoadListOfCommands = new DataReader.ListProcessor(Paths.Lists, Paths.Ext, "CommandList_SingleCommands");
            CMD_Singles = LoadListOfCommands.getCMDs();
        }
        #endregion
        #region ReadValue Functions
        public CommandProcessor.InputUtils ReadEnteredInput() => PlayerInput;
        public StateOfGame GameLoop() => GameState;
        public Dictionary<string, string> CMDSingles() => CMD_Singles;
        #endregion

        public void Initilise()
        {
            Console.SetWindowSize(150, 40); // Default Size = 120 : 30
        }

        public void PlayGame()
        {
            Console.Write("\n> ");
            PlayerInput.GetInput(Console.ReadLine());
        }
    }
}
