using Assignment3ThanosKatrakis.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3ThanosKatrakis.Products
{
    public class TeeShirt
    {
        public Color Color { get; }
        public Size Size { get; }
        public Fabric Fabric { get; }
        public decimal Price { get; set; }

        public TeeShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
    }
}

