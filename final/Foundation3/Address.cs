public class Address
{
    private int _streetNumerics;
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    public Address(int streetNumerics, string streetName, string city, string state, string country)
    {
        _streetNumerics = streetNumerics;
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddressString()
    {
        string addressInfo = $"{_streetNumerics} {_streetName} {_city} {_state} in {_country}";
        return addressInfo;
    }
}