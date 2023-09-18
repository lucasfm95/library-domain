using LibraryDomain.Data;

namespace LibraryDomain.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        
        var accountData = new AccountData()
        {
            Number = "teste",
            Customer = new CustomerData(),
            Transactions = new List<TransactionAccountData>()
        };


    }
}