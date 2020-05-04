using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TextUtilities;

namespace CommandProcessor
{
    class InputUtils
    {
        private readonly TextUtilities.Tokenization Tokeniz = new TextUtilities.Tokenization();
        private readonly TextUtilities.StemTools Stem = new TextUtilities.StemTools();
        private readonly WordCleaner Clean = new WordCleaner();

        private string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;

        public string ReadRawInput() => rawInput;
        public string[] ReadCleanedInputTokens() => cleanedInputTokens;
        public string[] ReadStemmedInputTokens() => stemmedInputTokens;

        public void GetInput(string input)
        {
            rawInput = Clean.Trim(input);
            cleanedInputTokens = Tokeniz.InputString(rawInput);
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
