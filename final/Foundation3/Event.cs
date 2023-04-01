public class Event{
    // Functional Methods
    public string ShortM(string eventType){
        return $"Type of event: {eventType}\nTitle: {_title}\nDate: {_date}";
    }
    public string StandardM(){
        return $"Event Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    // Member Variables
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Getter and Setter Methods
    public string GetTitle(){
        return _title;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetDate(){
        return _date;
    }
    public string GetTime(){
        return _time;
    }
    public string GetAddress(){
        return _address.GetAddress();
    }

    // Constructor Methods
    public Event(string title, string descrip, string date, string time, Address address){
        _title = title;
        _description = descrip;
        _date = date;
        _time = time;
        _address = address;
    }
}