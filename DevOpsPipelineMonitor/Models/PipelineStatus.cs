namespace DevOpsPipelineMonitor.Models
{
    public class PipelineStatus
    {
        public string PipelineName { get; set; } = string.Empty;

        public string Tool { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string LastRun { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public string Logs { get; set; } = string.Empty;
    }
}