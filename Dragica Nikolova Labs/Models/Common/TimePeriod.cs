namespace Models.Common
{
    /// <summary>
    /// Stores the duration of a period in days, months or years.
    /// </summary>
    public struct TimePeriod
    {
        /// <summary>
        /// Stores the duration of a period in an integer number.
        /// </summary>
        public int Period { get; set; }

        /// <summary>
        /// Specifies the associated unit of time of the particular period.
        /// </summary>
        public UnitOfTime Unit { get; set; }
        
    }
}
