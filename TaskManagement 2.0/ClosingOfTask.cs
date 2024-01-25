using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class ClosingOfTask
    {
        static string file = "TaskLog.csv";
        public static void ClosingTask()
        {
            CSV_Creation CSV = new CSV_Creation();
            List<string[]> result = CSV.CreateInfo(file, 6);
            DateTime DandT = DateTime.Now;
            string DaT = DandT.ToString();

            int index = Index(CSV, result.Count);
            string status = Status();
            result = Processing(result, index, status, DaT);
            CSV.CreateTask(result, file);

            Console.WriteLine("\nYou may now proceed to verifying the task that you've just closed!\nPress any key to continue...");
            Console.ReadKey();
            Start.Initiate();
        }

        private static int Index(CSV_Creation CSV, int tasks)
        {
            List<string[]> database = CSV.CreateInfo(file, 6);
            int index = 0;

            Console.Clear();
            ViewingOfTasks.ClosingTasksDisplay();
            Console.WriteLine();
            
            do
            {
                Console.Write("Pick a number to close the task: ");
            } while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > tasks);

            return index;
        }
        private static string Status()
        {
            string status = "";

            Console.WriteLine("\nThe following are the options for the task's status:");
            Console.WriteLine("A - Complete");
            Console.WriteLine("B - Not Complete");
            Console.Write("\nType your preferred letter: ");

            string uInput = Console.ReadLine().ToUpper();

            switch (uInput)
            {
                case "A":
                    status = "Complete";
                    break;
                case "B":
                    status = "Not Complete";
                    break;
                default:
                    Status();
                    break;
            }

            return status;
        }
        
        private static List<string[]> Processing(List<string[]> result, int index, string status, string DaT)
        {
            result[index][3] = DaT;
            result[index][4] = status;
            return result;
        }
    }
}
