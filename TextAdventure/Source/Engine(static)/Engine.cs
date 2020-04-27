using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class GameEngine
    {
        //private TextUtils_Tokenize TextUtils = new TextUtils_Tokenize();
        private InputUtils UserInput = new InputUtils();
        public InputUtils GetUserInput() => UserInput;

       // public string tmpInput;
       // public string GetTmpInput() => tmpInput;

        public void Initilise()
        {
            Console.SetWindowSize(150, 40); // Default Size = 120 : 30
        }

        public void PlayGame()
        {
            Console.Write("\n> ");
            UserInput.GetInput(Console.ReadLine());
        }
    }
}
