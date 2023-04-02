public class Cycling : Activity{
    // Functional Methods
    public override string GetDistance(){
        double distance = _speed / 60 * base.GetLength();
        return $"Distance {Math.Round(distance, 2).ToString("F1")} miles";
    }
    public override string GetSpeed(){
        return $"Speed {Math.Round(_speed, 2).ToString("F1")} mph";
    }
    public override string GetPace(){
        double distance = _speed / 60 * base.GetLength();
        double pace = base.GetLength() / distance;
        return $"Pace: {Math.Round(pace, 2).ToString("F1")} min per mile";
    }

    // Member Variables
    private double _speed;

    // Constructor Methods
    public Cycling(string date, string activityType, double length, double speed) : base(date, activityType, length){
        _speed = speed;
    }
}