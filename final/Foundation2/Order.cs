class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _orderTotal;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        foreach(Product product in _products)
        {
            _orderTotal += product.CalculatePrice();
        }

        if(_customer.IsUSAResident() == true)
        {
            _orderTotal += 5;
        }

        else
        {
            _orderTotal += 35;
        }
        
        return _orderTotal;
    }

    public void GetPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetProductID()}\n");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
}