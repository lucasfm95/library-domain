namespace LibraryDomain.Data;

public class AccountData
{
    public string? Branch { get; set; }
    public string? Number { get; set; }
    public string? Digit { get; set; }
    public string? Type { get; set; }
    public string? DocumentNumber { get; set; }
    public List<TransactionAccount>? Transactions { get; set; }
}