using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Core.Utils
{
    public class JobLoader
    {
        public Dictionary<string, JobTemplate> JobList;

        public JobLoader()
        {
            JobList = new Dictionary<string, JobTemplate>();

            var jobTemplate = JsonSerializer.Deserialize<JobTemplate>(File.ReadAllText("C:\\Users\\Xierf\\source\\repos\\35lib\\config\\class\\barb.json"));

            JobList.Add("barb", jobTemplate);
        }
    }
}