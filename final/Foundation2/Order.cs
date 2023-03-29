public class Order{
    // Functional Methods
    public double CalcTotalCost(){
        double shippingCost;
        if(_customer.CustInUS()){
            shippingCost = 5;
        }else{
            shippingCost = 35;
        }

        double CostOfProducts = 0;
        foreach (Product p in _products){
            CostOfProducts += p.CalcPrice();
        }

        return shippingCost + CostOfProducts;
    }
    public void AddProduct(Product p){
        _products.Add(p);
    }
    public void CreatePackingLabel(){
        foreach(Product p in _products){
            Console.WriteLine($"Product Name: {p.GetName()}, Product id: {p.GetId()}");
        }
    }
    public void CreateShippingLabel(){
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetFullAddress());
    }

    // Member Variables
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // G&S Methods
    public void SetCustomer(Customer c){
        _customer = c;
    }


}