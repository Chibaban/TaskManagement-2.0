using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement_2._0
{
    internal class CSV_Creation
    {
        public List<string[]> CreateInfo (string file, int indexes)
        {
            List<string[]> result = new List<string[]>();
            int tasks = 0;

            using (StreamReader reader = new StreamReader(file))
            {
                string[] info = new string[indexes];
                string line = "";
                while((line = reader.ReadLine()) != null)
                {
                    info = line.Split(',');
                    result.Add(info);
                    tasks++;
                }
            }
            return result;
        }

        public int Tasks()
        {
            int tasks = 0;

            using (StreamReader reader = new StreamReader("TaskLog.csv"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    tasks++;
                }
            }

            return tasks;
        }

        public void CreateTask(List<string[]> result, string file)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int a = 0; a < result.Count; a++)
                {
                    for (int b = 0; b < result[a].Length; b++)
                    {
                        if (b != result[a].Length - 1)
                        {
                            writer.Write(result[a][b] + ",");
                        }
                        else
                        {
                            writer.Write(result[a][b]);
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        public int Indexes()
        {
            List<string> result = new List<string>();
            int tasks = 0;

            using (StreamReader reader = new StreamReader("TaskLog.csv"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null) 
                {
                    tasks++;
                }
            }

            return tasks;
        }
    }
}
