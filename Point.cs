using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_and_deseralizaion
{
    [Serializable]
    public class Point
    {
       public float x { get; set; }
       public float y { get; set; }

       public Point() { }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
