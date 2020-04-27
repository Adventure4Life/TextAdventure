using System;

namespace TextAdventure
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            GameEngine Engine = new GameEngine();
            Engine.Initilise();

            while (GameState.GameHasNotEnded())
            {
                Engine.PlayGame();
                //Console.WriteLine($"User Entered this Line Cleaned with REGex \n| { Engine.GetTmpInput() }");
                DeBug.Print(Engine.GetUserInput().GetCleanedInputTokens(), "Tokens");
                DeBug.Print(Engine.GetUserInput().GetStemmedInputTokens(), "Stemmed Tokens");
            }
            DeBug.EndMarker();
        }
    }
}
