namespace LibraryDomain.Data;

public class TransactionData
{
    public string? Type { get; set; }
    public List<TransactionAccountData>? TransactionsAccount { get; set; }
}