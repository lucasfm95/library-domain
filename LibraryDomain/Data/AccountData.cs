namespace LibraryDomain.Data;

public class AccountData
{
    public string? Branch { get; set; }
    public string? BankName { get; set; }
    public string? Number { get; set; }
    public string? Digit { get; set; }
    public string? Type { get; set; }
    public string? DocumentNumber { get; set; }
    public List<TransactionData>? Transactions { get; set; }
    public long? Balance { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public CustomerData? Customer { get; set; }
}