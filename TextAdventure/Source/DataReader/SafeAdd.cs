using Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataReader
{
    class SafeAdd
    {
        private readonly Porter2Stemmer.EnglishPorter2Stemmer Porter = new Porter2Stemmer.EnglishPorter2Stemmer();

        // Add new Key / Value to a existing Dictionary
        public Dictionary<string, string> Add(Dictionary<string, string> dictionary, string key, string value)
        {
            value = Porter.Stem(value).Value;
            key = Porter.Stem(key).Value;
            //Console.WriteLine(value);
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
            return dictionary;
        }
        //Add a List<string> to another List<string>
        public List<string> Add(List<string> OrigList, List<string> AddList)
        {
            List<string> returnData = new List<string>(OrigList);
            foreach (string str in AddList)
            {
                if (!returnData.Contains(str))
                    returnData.Add(str);
            }
            return returnData;
        }
        public Dictionary<string, string> Add(Dictionary<string, string> target, Dictionary<string, string> copyThis)
        {
            foreach (var item in copyThis)
            {
                if (!target.ContainsKey(item.Key))
                {
                    target.Add(item.Key, item.Value);
                }
            }
            return target;
        }
    }
}
