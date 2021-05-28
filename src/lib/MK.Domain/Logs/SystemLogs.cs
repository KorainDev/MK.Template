using System;

namespace MK.Domain.Logs
{
    /// <summary>
    /// Represent system log entity
    /// </summary>
    public class SystemLogs : BaseEntity
    {
        public string Description { get; set; } = null;
        public string FullException { get; set; } = null;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}