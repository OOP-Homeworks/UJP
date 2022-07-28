using System;
using System.Collections.Generic;

namespace homework
{
    public struct Point
    {
        int x;
        int y;

        public Point(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
    }
}