using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class ViewingOfTasks
    {
        public static void ViewingTasks()
        {
            int indexes = 0;
            int numbering = 0;

            Console.Clear();
            Console.WriteLine(" __      ___               _               _______        _        \r\n \\ \\    / (_)             (_)             |__   __|      | |       \r\n  \\ \\  / / _  _____      ___ _ __   __ _     | | __ _ ___| | _____ \r\n   \\ \\/ / | |/ _ \\ \\ /\\ / / | '_ \\ / _` |    | |/ _` / __| |/ / __|\r\n    \\  /  | |  __/\\ V  V /| | | | | (_| |    | | (_| \\__ \\   <\\__ \\\r\n     \\/   |_|\\___| \\_/\\_/ |_|_| |_|\\__, |    |_|\\__,_|___/_|\\_\\___/\r\n                                    __/ |                          \r\n                                   |___/                           ");
            
            using (StreamReader reader = new StreamReader("TaskLog.csv"))
            {
                string[] split = new string[5];
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine();
                    split = line.Split(',');
                    if (numbering == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(indexes + "  "); // Move this line before printing the line
                    }
                    indexes++;
                    for (int i = 0; i < split.Length; i++)
                    {
                        Console.Write(split[i]);
                        if (split[i].Length < 35)
                        {
                            if (i != 4)
                            {
                                for (int len = split[i].Length; len < 24; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                            else
                            {
                                for (int len = split[i].Length; len < 16; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                        }
                        numbering++;
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            Start.Initiate();
        }

        public static void ClosingTasksDisplay()
        {
            int indexes = 0;
            int numbering = 0;

            Console.Clear();
            Console.WriteLine("   _____ _           _               _______        _        \r\n  / ____| |         (_)             |__   __|      | |       \r\n | |    | | ___  ___ _ _ __   __ _     | | __ _ ___| | _____ \r\n | |    | |/ _ \\/ __| | '_ \\ / _` |    | |/ _` / __| |/ / __|\r\n | |____| | (_) \\__ \\ | | | | (_| |    | | (_| \\__ \\   <\\__ \\\r\n  \\_____|_|\\___/|___/_|_| |_|\\__, |    |_|\\__,_|___/_|\\_\\___/\r\n                              __/ |                          \r\n                             |___/                           ");

            using (StreamReader reader = new StreamReader("TaskLog.csv"))
            {
                string[] split = new string[5];
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine();
                    split = line.Split(',');
                    if (numbering == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(indexes + "  ");
                    }
                    indexes++;
                    for (int i = 0; i < split.Length; i++)
                    {
                        Console.Write(split[i]);
                        if (split[i].Length < 35)
                        {
                            if (i != 4)
                            {
                                for (int len = split[i].Length; len < 24; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                            else
                            {
                                for (int len = split[i].Length; len < 16; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                        }
                        numbering++;
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void VerifyingTasksDisplay()
        {
            int indexes = 0;
            int numbering = 0;

            Console.Clear();
            Console.WriteLine(" __      __       _  __       _               _______        _        \r\n \\ \\    / /      (_)/ _|     (_)             |__   __|      | |       \r\n  \\ \\  / /__ _ __ _| |_ _   _ _ _ __   __ _     | | __ _ ___| | _____ \r\n   \\ \\/ / _ \\ '__| |  _| | | | | '_ \\ / _` |    | |/ _` / __| |/ / __|\r\n    \\  /  __/ |  | | | | |_| | | | | | (_| |    | | (_| \\__ \\   <\\__ \\\r\n     \\/ \\___|_|  |_|_|  \\__, |_|_| |_|\\__, |    |_|\\__,_|___/_|\\_\\___/\r\n                         __/ |         __/ |                          \r\n                        |___/         |___/                           ");

            using (StreamReader reader = new StreamReader("TaskLog.csv"))
            {
                string[] split = new string[5];
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine();
                    split = line.Split(',');
                    if (numbering == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(indexes + "  ");
                    }
                    indexes++;
                    for (int i = 0; i < split.Length; i++)
                    {
                        Console.Write(split[i]);
                        if (split[i].Length < 35)
                        {
                            if (i != 4)
                            {
                                for (int len = split[i].Length; len < 24; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                            else
                            {
                                for (int len = split[i].Length; len < 16; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                        }
                        numbering++;
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void ViewingVerifiedTasks()
        {
            int indexes = 0;
            int numbering = 0;

            Console.Clear();
            Console.WriteLine(" __      ___               _              __      __       _  __ _          _   _______        _        \r\n \\ \\    / (_)             (_)             \\ \\    / /      (_)/ _(_)        | | |__   __|      | |       \r\n  \\ \\  / / _  _____      ___ _ __   __ _   \\ \\  / /__ _ __ _| |_ _  ___  __| |    | | __ _ ___| | _____ \r\n   \\ \\/ / | |/ _ \\ \\ /\\ / / | '_ \\ / _` |   \\ \\/ / _ \\ '__| |  _| |/ _ \\/ _` |    | |/ _` / __| |/ / __|\r\n    \\  /  | |  __/\\ V  V /| | | | | (_| |    \\  /  __/ |  | | | | |  __/ (_| |    | | (_| \\__ \\   <\\__ \\\r\n     \\/   |_|\\___| \\_/\\_/ |_|_| |_|\\__, |     \\/ \\___|_|  |_|_| |_|\\___|\\__,_|    |_|\\__,_|___/_|\\_\\___/\r\n                                    __/ |                                                               \r\n                                   |___/                                                                ");

            using (StreamReader reader = new StreamReader("TaskLogVerification.csv"))
            {
                string[] split = new string[5];
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine();
                    split = line.Split(',');
                    if (numbering == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write(indexes + "  "); // Move this line before printing the line
                    }
                    indexes++;
                    for (int i = 0; i < split.Length; i++)
                    {
                        Console.Write(split[i]);
                        if (split[i].Length < 35)
                        {
                            if (i != 4)
                            {
                                for (int len = split[i].Length; len < 24; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                            else
                            {
                                for (int len = split[i].Length; len < 16; len++)
                                {
                                    Console.Write(' ');
                                }
                            }
                        }
                        numbering++;
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            Start.Initiate();
        }
    }
}
