using Bogus;
using FluentAssertions;
using LibraryDomain.Data;

namespace LibraryDomain.Tests;

public class AccountDataTest
{
    [Fact]
    public void GenerateAccountData()
    {

        var transactionAccountData = new Faker<TransactionAccountData>("pt_BR")
            .RuleFor(property => property.Id, func => func.Random.Int(1,100000));


        var customerData = new Faker<CustomerData>("pt_BR")
            .RuleFor(x => x.FirstName, f => f.Name.FullName());

        
        var accountsData = new Faker<AccountData>("pt_BR")
            .RuleFor(property => property.Balance, f => f.Random.Int(1,100000))
            .RuleFor(property => property.BankName, f => f.Name.FullName())
            .RuleFor(property => property.Number, f => f.Finance.Account())
            .RuleFor(property => property.Customer, f => customerData)
            .RuleFor(property => property.Transactions, func => transactionAccountData.Generate(500))
            .Generate(500);

    }
}