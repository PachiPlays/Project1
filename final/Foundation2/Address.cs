public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _isInUSA;

    public Address(string streetAddress, string city, string stateOrProvince, string country, bool isInUsa)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _isInUSA = isInUsa;
    }


    public string GetAddressInfo()
    {
        string nl = Environment.NewLine;
        string info = $"{_streetAddress}, {_city}, {_stateOrProvince}{nl}{_country}{nl}In USA: {_isInUSA}";
        return info;
    }

    public bool CheckIfInUSA()
    {
        return _isInUSA;
    }
}