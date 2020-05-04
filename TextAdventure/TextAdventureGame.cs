using System;
using Engine;

namespace TextAdventure
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            GameEngine Engine = new GameEngine();
            Engine.Initilise();

            while (Engine.GameLoop().GameHasNotEnded())
            {
                Engine.PlayGame();
                dBug.Print(Engine.ReadEnteredInput().ReadRawInput(), "User Inputted, Cleaned with RegEX");
                dBug.Print(Engine.ReadEnteredInput().ReadCleanedInputTokens(), "As Tokens");
                dBug.Print(Engine.ReadEnteredInput().ReadStemmedInputTokens(), "As Stemmed Tokens");
                dBug.Print(Engine.CMDSingles(), "List of Single Commands");
            }
            dBug.Pause("End of Application");
        }
    }
}
