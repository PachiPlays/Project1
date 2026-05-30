using System.Runtime.Intrinsics.X86;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckIfInUSA()
    {
        bool B1 = _address.CheckIfInUSA();
        return B1;
    }

    public string GetCustomerInfo()
    {
        string aInfo = _address.GetAddressInfo();
        string cInfo = $"{_name}\n{aInfo}";
        return cInfo;
    }
}