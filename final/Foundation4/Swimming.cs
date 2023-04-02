public class Swimming : Activity{
    // Functional Methods
    public override string GetDistance(){
        double distance = _nLaps * 50 / 1000 * 0.62;
        return $"Distance {Math.Round(distance, 2).ToString("F1")} miles";
    }
    public override string GetSpeed(){
        double distance = _nLaps * 50 / 1000 * 0.62;
        double speed = distance / base.GetLength() * 60;
        return $"Speed {Math.Round(speed, 2).ToString("F1")} mph";
    }
    public override string GetPace(){
        double distance = _nLaps * 50 / 1000 * 0.62;
        double pace = base.GetLength() / distance;
        return $"Pace: {Math.Round(pace, 2).ToString("F1")} min per mile";
    }

    // Member Variables
    private int _nLaps;

    // Constructor Methods
    public Swimming(string date, string activityType, int length, int nLaps) : base(date, activityType, length){
        _nLaps = nLaps;
    }
}