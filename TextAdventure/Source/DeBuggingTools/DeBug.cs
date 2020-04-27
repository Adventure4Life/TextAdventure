using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    static class DeBug
    {
        //***********************************************************************************************************
        //***************** Various Print Functions *****************************************************************
        //***********************************************************************************************************
        public static void EndMarker()
        {
            InputUtils input = new InputUtils();
            input.Pause("End of Application");
        }
        public static void Print(List<string> list, string txt) // - Print: List<string>
        {
            Console.WriteLine($"\n{ txt }");
            foreach (string line in list)
            {
                Console.WriteLine($"  { line }");
            }
        }

        public static void Print(string[] list, string txt) // - Print: List<string>
        {
            Console.WriteLine($"\n{ txt }");
            foreach (string line in list)
            {
                Console.WriteLine($"  { line }");
            }
        }
    }
}
