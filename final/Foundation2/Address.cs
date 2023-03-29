public class Address{
    // Functional Methods
    public bool InUS(){
        if(_country == "USA" || _country == "usa"){
            return true;
        }else{
            return false;
        }
    }
    public string GetFullAddress(){
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }

    // Member Variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor Methods
    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}