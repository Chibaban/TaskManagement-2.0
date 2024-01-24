using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class Start
    {
        public static void Initiate()
        {
            Console.Clear();
            Console.WriteLine("  _______        _    _                 \r\n |__   __|      | |  | |                \r\n    | | __ _ ___| | _| |     ___   __ _ \r\n    | |/ _` / __| |/ / |    / _ \\ / _` |\r\n    | | (_| \\__ \\   <| |___| (_) | (_| |\r\n    |_|\\__,_|___/_|\\_\\______\\___/ \\__, |\r\n                                   __/ |\r\n                                  |___/ ");
            Console.WriteLine("\nPick any of the following features:\n");
            Console.WriteLine("A - Creating Task");
            Console.WriteLine("B - Closing Task");
            Console.WriteLine("C - Verifying Task");
            Console.WriteLine("D - Viewing Tasks");
            Console.WriteLine("E - Verification Status");
            Console.Write("\nType your preferred letter: ");

            string uInput = Console.ReadLine().ToUpper();

            switch (uInput)
            {
                case "A":
                    CreationOfTask.CreatingTask();
                    break;
                case "B":
                    ClosingOfTask.ClosingTask();
                    break; 
                case "C":
                    VerifyingOfClass.VerifyingClass();
                    break;
                case "D":
                    ViewingOfTasks.ViewingTasks();
                    break;
                case "E":
                    ViewingOfTasks.ViewingVerifiedTasks();
                    break;
                default:
                    Initiate();
                    break;
            }
        }
    }
}
