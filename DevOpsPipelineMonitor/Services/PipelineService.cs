using DevOpsPipelineMonitor.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DevOpsPipelineMonitor.Services
{
    public class PipelineService
    {
        public List<PipelineStatus> GetPipelines()
        {
            string filePath = "Data/pipelines.json";

            if (!File.Exists(filePath))
            {
                return new List<PipelineStatus>();
            }

            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<PipelineStatus>>(json)
                   ?? new List<PipelineStatus>();
        }
    }
}