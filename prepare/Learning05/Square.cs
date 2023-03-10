public class Square : Shape{
    // Functional Methods
    public override double GetArea(){
        return _side * _side;
    }
    // Member Variables
    private double _side;

    // Constructor Methods
    public Square(string color, double side) : base(color){
        base.SetColor(color);
        _side = side;
    }

}