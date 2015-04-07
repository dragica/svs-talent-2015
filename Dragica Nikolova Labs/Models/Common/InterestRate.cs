namespace Models.Common
{
    /// <summary>
    /// Represents a percentage of the total borrowed amount that is paid over a certain unit of time
    /// </summary>
    public struct InterestRate
    {
        /// <summary>
        /// Specifies the amount paid by the debtor.
        /// </summary>
        public decimal Percent { get; set; }

        /// <summary>
        /// Specifies the associated unit of time over which the rate is paid.
        /// </summary>
        public UnitOfTime Unit  { get; set; }
    }
}
