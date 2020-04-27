using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TextAdventure
{
    class InputUtils
    {
        private TextUtils_Porter Stem = new TextUtils_Porter();

        private string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;

        public string GetRawInput() => rawInput;
        public string[] GetCleanedInputTokens() => cleanedInputTokens;
        public string[] GetStemmedInputTokens() => stemmedInputTokens;

        public void GetInput(string input)
        {
            rawInput = Regex.Replace(input, @"\s+", " "); //make sure there is only 1 white space between each word.
            cleanedInputTokens = Stem.InputString(rawInput);
            stemmedInputTokens = Stem.StemWordList(cleanedInputTokens);
        }

        //***********************************************************************************************************
        //***************** Console Pause Code **********************************************************************
        //***********************************************************************************************************

        public void Pause(string text) // Will Pause and output any text you send it
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** DEBUG : < " + text + " > : DEBUG ***");
            AnyKeyContinue();
        }

        public void Pause() // Will Pause just Pause and send a default text
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** DEBUG : < Press AnyKey to Continue > : DEBUG ***");
            AnyKeyContinue();
        }

        public void AnyKeyContinue()
        {
            Console.CursorVisible = false;
            Pause_AnyKey();
            Console.CursorVisible = true;
        }

        private void Pause_AnyKey()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable); // when a key is pressed it breaks the loop
            ClearInput();
        }

        private void ClearInput()
        {   //Loop through any inputs in the input buffer and "spends them" doing nothing.
            while (Console.KeyAvailable) { Console.ReadKey(true); }
        }
    }
}
