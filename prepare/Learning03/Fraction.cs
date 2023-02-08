using System;

public class Fraction
{
    // Class attributes
        private int _top;
        private int _bottom;

    // Constructor Methods
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

    // Dumb getter and setter methods
        // For _top
        public int GetTop()
        {
            return _top;
        }
        public void SetTop(int top)
        {
            _top = top;
        }

        // For _bottom
        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }
    // Return rpresentations of a fraction
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        public double GetDecimalValue()
        {
            return (double)_top / (double)_bottom;
        }




}