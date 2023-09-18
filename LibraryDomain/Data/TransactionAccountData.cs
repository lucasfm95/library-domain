namespace LibraryDomain.Data;

public class TransactionAccountData
{
    public long? Value { get; set; }
    public int? Id { get; set; }
    public string? Status { get; set; }
    public CommercialEstablishmentData? CommercialEstablishment { get; set; }
}