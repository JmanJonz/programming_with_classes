public class Product{
    // Functional Methods
    public double CalcPrice(){
        return _price * _quantity;
    }

    // Member Variables
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    // G&S Methods
    public string GetName(){
        return _name;
    }
    public int GetId(){
        return _id;
    }

    // Constructor Methods
    public Product(string name, int id, double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
}