public class Running : Activity{
    // Functional Methods
    public override string GetDistance(){
        return $"Distance {Math.Round(_distance, 2).ToString("F1")} miles";
    }
    public override string GetSpeed(){
        double speed = _distance / base.GetLength() * 60;
        return $"Speed {Math.Round(speed, 2).ToString("F1")} mph";
    }
    public override string GetPace(){
        double pace = base.GetLength() / _distance;
        return $"Pace: {Math.Round(pace, 2).ToString("F1")} min per mile";
    }

    // Member Variables
    private double _distance;

    // Constructor Methods
    public Running(string date, string activityType, double length, double distance) : base(date, activityType, length){
        _distance = distance;
    }
}