using System;

public class Address
{
	private readonly string _street;
	private readonly string _city;
	private readonly string _stateOrProvince;
	private readonly string _country;

	public Address(string street, string city, string stateOrProvince, string country)
	{
		_street = street ?? string.Empty;
		_city = city ?? string.Empty;
		_stateOrProvince = stateOrProvince ?? string.Empty;
		_country = country ?? string.Empty;
	}

	public bool LivesInUsa()
	{
		return _country.Equals("USA", StringComparison.OrdinalIgnoreCase)
			|| _country.Equals("United States", StringComparison.OrdinalIgnoreCase)
			|| _country.Equals("United States of America", StringComparison.OrdinalIgnoreCase);
	}

	public string GetFullAddressString()
	{
		return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
	}

	public override string ToString() => GetFullAddressString();
}