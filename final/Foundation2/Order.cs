public class Order
{
    List<Product> products = new List<Product>();
    private int _shippingCost;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        if (customer.CheckIfInUSA() == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        
    }

    public int GetTotalCost()
    {   int totalPrice = 0;
        foreach (Product product in products)
        {
        int P1 = product.GetTotalCost();
        totalPrice += P1;
        }
        totalPrice += _shippingCost;
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in products)
        {
            string pInfo = product.GetProductInfo();
            packingLabel += $"{pInfo} \n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string cInfo = _customer.GetCustomerInfo();
        return cInfo;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
}