using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    static class dBug
    {
        //***********************************************************************************************************
        //***************** Various Print Functions *****************************************************************
        //***********************************************************************************************************

        #region Print Dictionary<string, string>
        public static void Print(Dictionary<string, string> dic)
        {
            Console.WriteLine("");
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        public static void Print(Dictionary<string, string> dic, string txt)
        {
            Console.WriteLine($"\n{ txt }");
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("  {0} : {1}", item.Key, item.Value);
            }
        }
        #endregion
        #region Print List<string>
        public static void Print(List<string> list) // - Print: List<string>
        {
            Console.WriteLine("");
            foreach (string line in list)
            {
                Console.WriteLine($"  { line }");
            }
        }
        public static void Print(List<string> list, string txt) // - Print: List<string>
        {
            Console.WriteLine($"\n{ txt }");
            foreach (string line in list)
            {
                Console.WriteLine($"  { line }");
            }
        }
        #endregion
        #region Print string
        public static void Print(string line)
        {
            Console.WriteLine("\n"+line);
        }
        public static void Print(string line, string txt)
        {
            Console.WriteLine($"\n{ txt }");
            Console.WriteLine($"  { line }");
        }
        #endregion
        #region Print string[]
        public static void Print(string[] list) // - Print: List<string>
        {
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
        #endregion

        //
        //***********************************************************************************************************
        //***************** Console Pause Code **********************************************************************
        //***********************************************************************************************************

        public static void Pause(string text) // Will Pause and output any text you send it
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** DEBUG : < " + text + " > : DEBUG ***");
            AnyKeyContinue();
        }

        public static void Pause() // Will Pause just Pause and send a default text
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** DEBUG : < Press AnyKey to Continue > : DEBUG ***");
            AnyKeyContinue();
        }

        public static void AnyKeyContinue()
        {
            Console.CursorVisible = false;
            Pause_AnyKey();
            Console.CursorVisible = true;
        }

        private static void Pause_AnyKey()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable); // when a key is pressed it breaks the loop
            ClearInput();
        }

        private static void ClearInput()
        {   //Loop through any inputs in the input buffer and "spends them" doing nothing.
            while (Console.KeyAvailable) { Console.ReadKey(true); }
        }
    }
}


/*
 *         // Print : string
        public static void Print()
        {
            Console.WriteLine("");
        }


        // Print : Dictionary<string,string>
        public static void PrintDic(Dictionary<string,string> dic)
        {
            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        //public static void Print(Dictionary<string, string> dic) // Print Dictionary<string, string> key : value
        //{
        //    foreach (KeyValuePair<string, string> item in dic)
        //    {
        //        Console.WriteLine("{0} : {1}", item.Key, item.Value);
        //    }
        //}
        //public static void Print(Dictionary<string, string> dic, string txt) // Print Dictionary<string, string> key : value
        //{
        //    Console.WriteLine($"\n{ txt }");
        //    foreach (KeyValuePair<string, string> item in dic)
        //    {
        //        Console.WriteLine("  {0} : {1}", item.Key, item.Value);
        //    }
        //}

        // Print : BOOL
        public static void Print(bool TF) // - Print: Bool
        {
            string line = "False";
            if (TF)
                line = "True";
            Console.WriteLine(line + "\n");
        }

        public static void Print(bool TF, string txt) // - Print: Bool
        {
            Console.WriteLine($"\n{ txt }");
            string line = "False";
            if (TF)
                line = "True";
            Console.WriteLine(line + "\n");
        }
 */
