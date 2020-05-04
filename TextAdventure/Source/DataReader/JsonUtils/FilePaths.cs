using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataReader
{
    class FilePaths
    {
        public string Ext { get; } = @".json";
        public string Lists { get; } = @"..\Data\_FileLists\";
        public string Actions { get; } = @"..\Data\WordLists\Actions\";

    }
}

//public Dictionary<string, string> path { get; }
//public FilePaths()
//{
//    path = new Dictionary<string, string>();
//    path.Add("CommandList_SingleCommands", @"..\Data\_FileLists\");
//    path.Add("look", @"..\Data\WordLists\Actions\");
//}