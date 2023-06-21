using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Calculator
{
    public class Logs
    {
        public List<History> logs { get; set; } = new List<History>();
        public string logsPath = "logs.json";

        public Logs()
        {
            
        }

        public void SaveToFile(History newLog)
        {
            this.logs.Add(newLog);

            string json = JsonSerializer.Serialize(logs);
            File.WriteAllText(logsPath, json);
        }
    }
}
