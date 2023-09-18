using System;
namespace LibraryDomain.Data
{
	public class AddressData
	{
		public string? Street { get; set; }
		public string? CityName { get; set; }
		public string? State { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}

