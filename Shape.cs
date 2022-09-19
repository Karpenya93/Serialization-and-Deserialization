using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_and_deseralizaion
{
    [Serializable]
    public class Shape
    {
        public Point ShapePoint { get; set; } = new Point();
        public float _Length { get; set; }
        public float _Height { get; set; }
        public string _Name { get; set; }
        public Shape() { }

        public Shape(Point shapePoint, float length, float height, string name)
        {
            ShapePoint = shapePoint;
            _Length = length;
            _Height = height;
            _Name = name;
        }
    }
}
