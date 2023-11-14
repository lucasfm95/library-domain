using Bogus;
using LibraryDomain.Data;

namespace LibraryDomain;

public class GeneratorDataObject
{
    public List<AccountData> GenerateAccountDataList()
    {
        var commercialEstablishment = new Faker<CommercialEstablishmentData>("pt_BR")
            .RuleFor(property => property.DocumentNumber, func => func.Finance.Account(14))
            .RuleFor(property => property.CreatedAt, func => func.Date.Recent())
            .RuleFor(property => property.Name, func => func.Company.CompanyName());

        var transactionAccountData = new Faker<TransactionAccountData>("pt_BR")
            .RuleFor(property => property.CommercialEstablishment, func => commercialEstablishment)
            .RuleFor(property => property.Id, func => func.Random.Int(1,100000));

        var address = new Faker<AddressData>("pt_BR")
            .RuleFor(property => property.CreatedAt, func => func.Date.Past())
            .RuleFor(property => property.UpdatedAt, func => func.Date.Recent())
            .RuleFor(property => property.ZipCode, func => func.Address.ZipCode())
            .RuleFor(property => property.Street, func => func.Address.StreetAddress())
            .RuleFor(property => property.State, func => func.Address.State())
            .RuleFor(property => property.CityName, func => func.Address.City()); 

        var customerData = new Faker<CustomerData>("pt_BR")
            .RuleFor(property => property.FirstName, func => func.Name.FullName())
            .RuleFor(property => property.Address, address);

        var transactionData = new Faker<TransactionData>("pt_BR")
            .RuleFor(property => property.Type, func => func.Random.Int(1,2).ToString())
            .RuleFor(property => property.TransactionsAccount, transactionAccountData.Generate(50));

        var accountsData = new Faker<AccountData>("pt_BR")
            .RuleFor(property => property.Balance, func => func.Random.Int(1,100000))
            .RuleFor(property => property.BankName, func => func.Name.FullName())
            .RuleFor(property => property.Number, func => func.Finance.Account())
            .RuleFor(property => property.Customer, customerData)
            .RuleFor(property => property.Transactions, transactionData.Generate(50))
            .Generate(50);

        return accountsData;
    } 
}