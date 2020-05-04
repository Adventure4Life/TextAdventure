using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextUtilities
{
    class WordCleaner
    {
        //Clean Unwanted Characters from a string
        public string Word(string word)
        {
            var banList = "~`!@#$%^&*()_+{}|[]\\:;\",<.>/?".ToCharArray();
            return string.Join("", word.Where(s => !banList.Contains(s)));
        }

        public string Trim(string line)
        {
            string input = Regex.Replace(line, @"\s+", " "); // Remove any occurrences of extra SPACES
            return input;
        }
    }
}
