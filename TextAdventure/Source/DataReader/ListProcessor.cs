using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using TextAdventure;

namespace DataReader
{
    class ListProcessor
    {
        private readonly SafeAdd Safe;
        private Dictionary<string, string> Cmds;
        private string Ext;

        public Dictionary<string, string> getCMDs() => Cmds;

        //private DataReader.RawListOfWords ListOfFilestoLoad;

        public ListProcessor(string path, string ext, string FileNameList)
        {
            Safe = new SafeAdd();
            Ext = ext;
            Cmds = new Dictionary<string, string>();
            LoadListIntoDictonary(JsonConvert.DeserializeObject<DataReader.RawListOfWords>(File.ReadAllText(path + FileNameList + Ext)));
        }

        public void LoadListIntoDictonary(DataReader.RawListOfWords RawFileList)
        {
            //dBug.Print(RawFileList.Name);
            //dBug.Print(RawFileList.Words, RawFileList.FilePath);
            
            List<DataReader.RawListOfWords> rawWordList = new List<DataReader.RawListOfWords>();
            foreach (string file in RawFileList.Words)
            {
                rawWordList.Add(JsonConvert.DeserializeObject<DataReader.RawListOfWords>(File.ReadAllText(RawFileList.FilePath + file + Ext)));
            }

            foreach (DataReader.RawListOfWords list in rawWordList)
            {
                foreach (string key in list.Words)
                {
                    Safe.Add(Cmds, key, list.Name);
                }
            }
            //dBug.Print(Cmds, "Finished Command List");
        }
    }
}

//foreach(KeyValuePair<string, string> entry in myDictionary)
//{
//    // do something with entry.Value or entry.Key
//}

