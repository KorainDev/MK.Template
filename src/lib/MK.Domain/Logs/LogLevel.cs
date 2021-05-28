namespace MK.Domain.Logs
{
    /// <summary>
    /// log level type
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// error level
        /// usage : when error happen and will affect programe logic
        /// </summary>
        Error = 1,

        /// <summary>
        /// information level
        /// usage: when developer want to log information for trace
        /// </summary>
        Information = 2,

        /// <summary>
        /// critical error level
        /// usage: when error happen and program will be down
        /// </summary>
        Critical = 3,

        /// <summary>
        /// warning error level
        /// usage : when error happend and will not affect the programe logic
        /// </summary>
        Warning = 4,
    }
}