using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class VerifyingOfClass
    {
        static string fileVerification = "TaskLogVerification.csv";
        public static void VerifyingClass()
        {
            CSV_Creation CSV = new CSV_Creation();
            List<string[]> resultsVerification = CSV.CreateInfo(fileVerification, 6);
            List<string[]> results = CSV.CreateInfo("TaskLog.csv", 6);
            DateTime DandT = DateTime.Now;
            string DaT = DandT.ToString();
            string[] VerificationLog = new string[6];

            int index = 0;

            Console.Clear();
            ViewingOfTasks.VerifyingTasksDisplay();

            int tasks = CSV.Indexes();

            Console.WriteLine();

            do
            {
                Console.Write("Pick a number that you want to verify: ");
            } while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > tasks || results[index][3] == "NULL");

            Console.Write("\nPlease input your name: ");

            string name = Console.ReadLine().ToUpper();

            Console.WriteLine("Choose a verification status for this task: ");
            Console.WriteLine("\nA - Verified");
            Console.WriteLine("B - For Revision");
            Console.Write("\nType your preferred letter: ");

            string uInput = Console.ReadLine().ToUpper();
            string status = Status(uInput);

            Console.Write("Please input your details about your verification: ");

            string details = Console.ReadLine().ToUpper();

            Console.Write("Provide additional comments about the verification: ");

            string comments = Console.ReadLine().ToUpper();

            VerificationLog[0] = name;
            VerificationLog[1] = DaT;
            VerificationLog[2] = status;
            VerificationLog[3] = details;
            VerificationLog[4] = comments;
            VerificationLog[5] = index.ToString();

            resultsVerification.Add(VerificationLog);
            CSV.CreateTask(resultsVerification, "TaskLogVerification.csv");
            Start.Initiate();
        }

        private static string Status(string uInput)
        {
            switch (uInput)
            {
                case "A":
                    return "Verified";
                case "B":
                    return "For Revision";
                default:
                    return "For Verification";
            }
        }
    }
}
