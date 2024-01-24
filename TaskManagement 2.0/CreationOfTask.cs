using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class CreationOfTask
    {
        public static void CreatingTask()
        {
            CSV_Creation CSV = new CSV_Creation();
            List<string[]> result = new List<string[]>();
            string file = "TaskLog.csv";
            string status = "Ongoing";
            DateTime DandT = DateTime.Now;
            string DaT = DandT.ToString();

            Console.Clear();

            Console.WriteLine("   _____                _   _               _______        _    \r\n  / ____|              | | (_)             |__   __|      | |   \r\n | |     _ __ ___  __ _| |_ _ _ __   __ _     | | __ _ ___| | __\r\n | |    | '__/ _ \\/ _` | __| | '_ \\ / _` |    | |/ _` / __| |/ /\r\n | |____| | |  __/ (_| | |_| | | | | (_| |    | | (_| \\__ \\   < \r\n  \\_____|_|  \\___|\\__,_|\\__|_|_| |_|\\__, |    |_|\\__,_|___/_|\\_\\\r\n                                     __/ |                      \r\n                                    |___/                       ");
            Console.Write("\nType your preferred task: ");

            string task = Console.ReadLine().ToUpper();

            Console.Write("Type the employee or person for this task: ");

            string name = Console.ReadLine().ToUpper();

            Console.Write("Provide comments for additional info: ");

            string comments = Console.ReadLine().ToUpper();

            result = CSV.CreateInfo(file, 6);
            int tasks = CSV.Tasks();

            string[] features = new string[6] { task, name, DaT, "NULL", status, comments };
            result.Add(features);
            CSV.CreateTask(result, file);

            Console.WriteLine("\nTask added to the list! You must first finish the task before verifying it. \nPress any key to continue...");
            Console.ReadKey();
            Start.Initiate();
        }
    }
}
