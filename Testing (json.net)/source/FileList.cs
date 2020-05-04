using System;
using System.Collections.Generic;
using System.Text;

namespace Testingjson
{
    class FileList
    {
        private string ListName;
        private List<string> FileNameList;

        public string GetListName() => ListName;
        public List<string> GetFileNameList() => FileNameList;

        public FileList()
        {
            ListName = "Single_Constants_Commands_File_List";
            FileNameList = new List<string>();
            FileNameList.Add("look");
            FileNameList.Add("game_quit");
            FileNameList.Add("north");
            FileNameList.Add("south");
            FileNameList.Add("east");
            FileNameList.Add("west");
        }
    }
}
