using System;
using System.Collections.Generic;
using System.Text;
using Data.Enums;

namespace Models
{
    public class CreateJobDTO
    {
        public string Type { get; set; }

        public string Payload { get; set; } // stored as JSON string, or use SQL Server's native JSON column if you want to query into it later
              
        public string CreatedBy { get; set; }

        public DateTime ScheduledAt { get; set; }

        public int RetryCount { get; set; }

        public int MaxRetries { get; set; }

        public string? IdempotencyKey { get; set; }
    }
}
