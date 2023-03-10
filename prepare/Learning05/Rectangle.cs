public class Rectangle : Shape{
    // Functional Methods
    public override double GetArea(){
        return _side1 * _side2;
    }
    // Member Variables
    private double _side1;
    private double _side2;

    // Constructor Methods
    public Rectangle(string color, double side1, double side2) : base(color){
        base.SetColor(color);
        _side1 = side1;
        _side2 = side2;
    }

}