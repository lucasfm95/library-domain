using System;
namespace LibraryDomain.Data;

public class CustomerData
{
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public DateTime CreatedAt { get; set; }
	public string? DocumentNumber { get; set; }
	public AddressData? Address { get; set; }
}