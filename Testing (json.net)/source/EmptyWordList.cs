using System;
using System.Collections.Generic;
using System.Text;

namespace Testingjson
{
    class EmptyWordList
    {
        private string KeyWord { get; set; }
        private List<string> Synonyms { get; set; }

        public string GetKeyWord() => KeyWord;
        public List<string> GetWordList() => Synonyms;
    }
}