using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class GridShould
    {
        [Fact]
        public void ComputeNextStage()
        {
            var points = new List<Point>
            {
                new Point(0,0),
                new Point(1,2)
                
            };
            var grid = new Grid(points);
            var result = grid.NextState();
            var expected = new List<Point>();
            
            


        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Grid
    {
        public int GridSize = 4;

        public Grid(List<Point> points)
        {
            throw new NotImplementedException();
        }

        public object NextState()
        {
            throw new NotImplementedException();
        }
    }
}