using System.ComponentModel;

public class Product
{
    private string _name;
    private int _productID;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int productID, int pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    
    public int GetTotalCost()
    {
        int totalCost = _pricePerUnit * _quantity;
        return totalCost;
    }

    public string GetProductInfo()
    {
        string pInfo = $"{_name}, {_productID}";
        return pInfo;
    }
}