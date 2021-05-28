using System;

namespace MK.Domain.Logs
{
    /// <summary>
    /// Represent system log entity
    /// </summary>
    public class SystemLogs : BaseEntity
    {
        public string Description { get; set; }
        public string FullException { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}