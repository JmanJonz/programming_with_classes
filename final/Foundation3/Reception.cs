public class Reception : Event{
    // Functional Methods
    public string FullM(){
        return $"{base.StandardM()}\nRSVP NOW AT: {_rsvpEmail}";
    }

    // Member Variables
    private string _rsvpEmail;

    // Constructor Methods
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address){
        _rsvpEmail = email;      
    }
}