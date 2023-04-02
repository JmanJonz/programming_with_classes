public class Activity{
    // Functional Methods
    public virtual string GetDistance(){
        return "Not Yet Overridden";
    }
    public virtual string GetSpeed(){
        return "Not Yet Overridden";
    }
    public virtual string GetPace(){
        return "Not Yet Overridden";
    }
    public string GetSummary(){
        return $"{_date} {_activityType} ({_length} min) - {GetDistance()}, {GetSpeed()}, {GetPace()}";
    }

    // Member Variables
    private string _date;
    private double _length;
    private string _activityType;

    // Getter and Setter Methods
    public double GetLength(){
        return _length;
    }

    // Constructor Methods
    public Activity(string date, string activityType, double length){
        _date = date;
        _length = length;
        _activityType = activityType;
    }
}