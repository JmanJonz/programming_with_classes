public class Circle : Shape{
    // Functional Methods
    public override double GetArea(){
        return 3.14159 * Math.Pow(_radius, 2);
    }
    // Member Variables
    private double _radius;

    // Constructor Methods
    public Circle(string color, double radius) : base(color){
        base.SetColor(color);
        _radius = radius;
    }

}