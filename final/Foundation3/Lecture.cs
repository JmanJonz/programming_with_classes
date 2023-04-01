public class Lecture : Event{
    // Functional Methods
    public string FullM(){
        return $"{base.StandardM()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    // Member Variables
    private string _speaker;
    private string _capacity;

    // Constructor Methods
    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base(title, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }
}