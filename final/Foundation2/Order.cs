public class Order
{
    private string _customerName;
    private double _totalCost;
    List<Product> _productList = new List<Product>();
    Customer _customer;
    public Order(int i)
    {
        if (i == 0)
        {
            _customer = new Customer(0);
            _customerName = _customer.GetName();
            Product product1 = new Product("Organic Matcha Green Tea Set", "TM-ORG-0155", 89.99, 2);
            Product product2 = new Product("Sustainable Bamboo Sunglasses", "EC-SUS-4411", 165.00, 1);
            Product product3 = new Product("French Cinema Classic DVD Collection", "FC-DVD-9966", 129.99, 1);
            _productList.Add(product1);
            _productList.Add(product2);
            _productList.Add(product3);
        }

        else if (i == 1)
        {   
            _customer = new Customer(1);
            _customerName = _customer.GetName();
            Product product1 = new Product("Irish Wool Artisan Throw Blanket", "SR-IRL-3283", 275.00, 1);
            Product product2 = new Product("Organic Lavender Essential Oil", "SR-ESS-5577", 45.99, 2);
            Product product3 = new Product("Vintage Penguin Classic Book Set", "LIT-VNT-8822", 124.99, 3);
            _productList.Add(product1);
            _productList.Add(product2);
            _productList.Add(product3);
        }
    }
    public double GetTotalCost()
    {
        return _totalCost;
    }

    public void SetTotalCost(double totalCost)
    {
        _totalCost = totalCost;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public List<Product> GetProductList()
    {
        return _productList;
    }

    public void SetProductList(List<Product> productList)
    {
        _productList = productList;
    }

    public int CalShippingCost()
    {
        if (_customer.IsUSA())
        {
            return 5;
        } 
        else
        {
            return 35;
        }
    }

    public double CalTotalCost()
    {
        foreach (Product product in _productList)
        {
            _totalCost += product.CalProductTotalCost();
        }
        
        _totalCost += CalShippingCost(); // add the shipping cost
        return _totalCost;
    }

    public void GetPackingLabel()
    {   
        foreach (Product product in _productList)
        {
            Console.WriteLine($"Name: {product.GetName()}\nID: {product.GetProductId()}\n");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customerName}\nAddress: {_customer.GetFullAddress()}\n{new string('-', 50)}");
    }





}