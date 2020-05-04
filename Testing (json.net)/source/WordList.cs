using System;
using System.Collections.Generic;
using System.Text;

namespace Testingjson
{
    class WordList
    {
        private string ListName;
        private Dictionary<string,string> WorldsInList;

        public string GetListName() => ListName;
        public Dictionary<string, string> GetWordList() => WorldsInList;

        public WordList()
        {
            ListName = "look";
            WorldsInList = new Dictionary<string, string>();

            WorldsInList.Add("attention", ListName);
            WorldsInList.Add("beholding", ListName);
            WorldsInList.Add("case", ListName);
            WorldsInList.Add("cast", ListName);
            WorldsInList.Add("check", ListName);
            WorldsInList.Add("consider", ListName);
            WorldsInList.Add("contemplate", ListName);
            WorldsInList.Add("contemplation", ListName);
            WorldsInList.Add("examine", ListName);
            WorldsInList.Add("eye", ListName);
            WorldsInList.Add("focus", ListName);
            WorldsInList.Add("gander", ListName);
            WorldsInList.Add("gaze", ListName);
            WorldsInList.Add("glance", ListName);
            WorldsInList.Add("glimpse", ListName);
            WorldsInList.Add("inspect", ListName);
            WorldsInList.Add("inspection", ListName);
            WorldsInList.Add("leer", ListName);
            WorldsInList.Add("mark", ListName);
            WorldsInList.Add("notice", ListName);
            WorldsInList.Add("noticing", ListName);
            WorldsInList.Add("observation", ListName);
            WorldsInList.Add("observe", ListName);
            WorldsInList.Add("ogle", ListName);
            WorldsInList.Add("peek", ListName);
            WorldsInList.Add("peep", ListName);
            WorldsInList.Add("peer", ListName);
            WorldsInList.Add("reconnaissance", ListName);
            WorldsInList.Add("regard", ListName);
            WorldsInList.Add("regarding", ListName);
            WorldsInList.Add("review", ListName);
            WorldsInList.Add("scan", ListName);
            WorldsInList.Add("scrutinize", ListName);
            WorldsInList.Add("scrutiny", ListName);
            WorldsInList.Add("see", ListName);
            WorldsInList.Add("sight", ListName);
            WorldsInList.Add("slant", ListName);
            WorldsInList.Add("spot", ListName);
            WorldsInList.Add("spy", ListName);
            WorldsInList.Add("stare", ListName);
            WorldsInList.Add("study", ListName);
            WorldsInList.Add("surveillance", ListName);
            WorldsInList.Add("survey", ListName);
            WorldsInList.Add("view", ListName);
            WorldsInList.Add("viewing", ListName);
            WorldsInList.Add("watch", ListName);
        }
    }
}