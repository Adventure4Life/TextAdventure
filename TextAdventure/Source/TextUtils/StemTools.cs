using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextUtilities
{
    class StemTools
    {
        Porter2Stemmer.EnglishPorter2Stemmer Porter = new Porter2Stemmer.EnglishPorter2Stemmer();
        public string[] StemWordList(string[] wordlist)
        {
            string[] copyArray = wordlist.ToArray();
            for (int i = 0; i < copyArray.Length; i++)
            {
                string StemValue = Porter.Stem(copyArray[i]).Value;
                copyArray[i] = StemValue;
            }
            return copyArray;
        }
    }
}
