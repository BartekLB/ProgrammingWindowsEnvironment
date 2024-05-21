using System;

namespace TaskSchedulerApp
{
    public class TaskInfo
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? LastRunTime { get; set; }
        public string Status { get; set; }
        public int? IntervalMinutes { get; set; }
        public int DurationMinutes { get; set; }
        public int RunCount { get; set; }
        public int SuccessCount { get; set; }
    }
}