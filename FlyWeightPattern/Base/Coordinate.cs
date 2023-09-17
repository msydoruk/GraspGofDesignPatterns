﻿namespace FlyWeightPattern.Base
{
    public class Coordinate
    {
        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
