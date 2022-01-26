using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;
namespace Core.Utils
{
    public class JobLoader
    {
        public Dictionary<string, JobTemplate> JobList;

        public JobLoader()
        {
            JobList = new Dictionary<string, JobTemplate>();
            var txtFiles = Directory.EnumerateFiles("C:\\Users\\Xierf\\source\\repos\\35lib\\config\\class", "*.json");

            var options = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
            };
           

            foreach (string currentFile in txtFiles)
            {
                Console.WriteLine(currentFile);
                var jobTemplate = JsonSerializer.Deserialize<JobTemplate>(File.ReadAllText(currentFile),options);

                JobList.Add(jobTemplate.Name, jobTemplate);
            }
        }
    }
}