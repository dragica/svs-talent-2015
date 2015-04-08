namespace Models.Common
{
    /// <summary>
    /// Stores a specific amount of money in the corresponding currency type.
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// Stores a specific amount of money.
        /// </summary>
        public decimal Amount { get; set; }  
      
        /// <summary>
        /// Stores currency type of the particular amount.
        /// </summary>
        public string Currency { get; set; }
       
    }
}
