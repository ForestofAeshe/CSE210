using System;
using System.Diagnostics;

namespace Fraction
{
    public class Fraction
    {
        private float _top;
        private float _bottom;
        private string _fraction;
        private float _decimal;

        // pretty constructor XP
        // public Fraction(float inputTop = 1, float inputBottom = 1)
        // {
        //     SetTop(inputTop);
        //     SetBottom(inputBottom);
        // }
        
        public Fraction()
        {
            //First Constructor
            SetTop(1);
            SetBottom(1);
        }
        public Fraction(float input)
        {
            //Second Constructor
            SetTop(input);
            SetBottom(1);
        }
        public Fraction(float inputTop, float inputBottom)
        {
            //Third Constructor
            SetTop(inputTop);
            SetBottom(inputBottom);
        }
        public void SetTop(float input)
        {
            _top = input;
        }
        public void SetBottom(float input)
        {
            if (input <= 0)
            {
                Console.WriteLine("Error, Default Denominator Set To 1.");
                input = 1;
            }
            else
            {
                _bottom = input;
            }
        }
        public float GetTop()
        {
            return _top;
        }
        public float GetBottom()
        {
            return _bottom;
        }
        public string GetFractionString()
        {
            _fraction = $"{_top}/{_bottom}";
            return _fraction;
        }
        public double GetDecimal()
        {
            _decimal = _top/_bottom;
            return _decimal;
        }
    }
}