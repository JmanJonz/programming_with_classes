public class Customer{
    // Functional Methods
    public bool CustInUS(){
        return _address.InUS();
    }

    // Member Variables
    private string _name;
    private Address _address;

    // G & S Methods
    public string GetName(){
        return _name;
    }
    public Address GetAddress(){
        return _address;
    }

    // Constructor Methods
    public Customer(string name, Address a){
        _name = name;
        _address = a;
    }

}