namespace Models.Common
{
    /// <summary>
    /// Enumerate the transaction statuses.
    /// </summary>
    public enum TransactionStatus : byte
    {
        InProccess, Completed, CompletedWithWarning, Failed
    }
}
