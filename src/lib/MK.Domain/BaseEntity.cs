namespace MK.Domain
{
    /// <summary>
    /// represent base domain entity
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// gets or sets entity identifier
        /// </summary>
        public int ID { get; set; }
    }
}