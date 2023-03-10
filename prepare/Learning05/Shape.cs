public abstract class Shape{
    // Functional Methods
    public abstract double GetArea();

    // Member Variables
    private string _color;

    // Getter & Setter Methods
    public void SetColor(string color){
        _color = color;
    }
    public string GetColor(){
        return _color;
    }

    // Constructor Methods
    public Shape(string color){
        _color = color;
    }
}