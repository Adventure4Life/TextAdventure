using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace TextUtilities
{
    class Tokenization
    {
        private readonly WordCleaner Clean = new WordCleaner();

        public string[] InputString(string input)
        {
            List<string> cleanedInputList = new List<string>();
            string[] raw_cleanedInputString = input.ToLower().Trim().Split(null);

            foreach (string word in raw_cleanedInputString)
            {
                if (word != "")
                {
                    string s = Clean.Word(word);
                    if (s != "") cleanedInputList.Add(s);
                }
            }

            string[] copyList2String = new string[cleanedInputList.Count];
            cleanedInputList.CopyTo(copyList2String);
            return copyList2String;
        }
    }
}