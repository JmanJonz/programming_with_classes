public class OutdoorGathering : Event{
    // Functional Methods
    public string FullM(){
        return $"{base.StandardM()}\nA note on weather: {_weather}";
    }

    // Member Variables
    private string _weather;

    // Constructor Methods
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address){
        _weather = weather;      
    }
}