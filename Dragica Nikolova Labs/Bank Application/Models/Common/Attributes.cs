using System;
using Models.Common;

[AttributeUsage(AttributeTargets.Class)]
public class AccountMetadataAttribute : Attribute
{
    public string AccountDescription { get; private set; }
    public string AccountLimitations { get; private set; }
    public AccountMetadataAttribute(string description, string limitations)
    {
        this.AccountDescription = description;
        this.AccountLimitations = limitations;
    }
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class FormatRestrictionAttribute : Attribute
{
    public string FormatString { get; private set; }
    public int MaxLength { get; private set; }
    public FormatRestrictionAttribute(string f, int ml)
    {
        this.FormatString = f;
        this.MaxLength = ml;
    }
}
