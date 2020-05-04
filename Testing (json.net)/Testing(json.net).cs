using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Testingjson
{
    class Program
    {
        static void Main(string[] args)
        {


            //JsonConvert.DeserializeObject<object>jasonStrng
            string DataFilePath = @"..\Data\WordList_Look.json";
            Console.WriteLine(DataFilePath);

            //string MyFile = File.ReadAllText(DataFilePath + "WordList_Look.json");
            //DeBug.Print(MyFile);

            //EmptyWordList account = JsonConvert.DeserializeObject<EmptyWordList>(MyFile);
            //DeBug.Print("NAME : "+account.ListName);

            EmptyWordList option1 = JsonConvert.DeserializeObject<EmptyWordList>(File.ReadAllText(DataFilePath));
            DeBug.Print(option1.GetKeyWord(), "Keyword");
            DeBug.Print(option1.GetWordList(), "Synonyms");





            //FileList SingleCommands = new FileList();
            //WordList LookCommand = new WordList();
            //DeBug.Print(SingleCommands.GetFileNameList(), SingleCommands.GetListName());
            //DeBug.Print(LookCommand.GetWordList(), LookCommand.GetListName());
            DeBug.Pause("End of Application");
        }
    }
}
