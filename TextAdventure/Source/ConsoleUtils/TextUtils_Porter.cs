using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventure
{
    class TextUtils_Porter
    {
        private Porter2Stemmer.EnglishPorter2Stemmer StemWord = new Porter2Stemmer.EnglishPorter2Stemmer();

        public string[] InputString(string input)
        {
            List<string> cleanedInputList = new List<string>();
            string[] raw_cleanedInputString = input.ToLower().Trim().Split(null);

            foreach (string word in raw_cleanedInputString)
            {
                if (word != "")
                {
                    string s = CleanedWord(word);
                    if (s != "") cleanedInputList.Add(s);
                }
            }

            string[] copyList2String = new string[cleanedInputList.Count];
            cleanedInputList.CopyTo(copyList2String);
            return copyList2String;
        }

        public string[] StemWordList(string[] wordlist)
        {
            string[] copyArray = wordlist.ToArray();
            for (int i = 0; i < copyArray.Length; i++)
            {
                string StemValue = StemWord.Stem(copyArray[i]).Value;
                copyArray[i] = StemValue;
            }
            return copyArray;
        }

        //Clean Unwanted Characters from a string
        private string CleanedWord(string word)
        {
            var banList = "~`!@#$%^&*()_+{}|[]\\:;\",<.>/?".ToCharArray();
            return string.Join("", word.Where(s => !banList.Contains(s)));
        }
    }
}
