using Assignment3ThanosKatrakis.Enumerations;
using Assignment3ThanosKatrakis.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3ThanosKatrakis.Strategies.ProductVariationStrategy
{
    class ColorVariation : VariationStrategy
    {
        public void Cost(TeeShirt shirt)
        {
            switch (shirt.Color)
            {
                case Color.BLUE: shirt.Price += 0.5m; break;
                case Color.GREEN: shirt.Price += 0.6m; break;
                case Color.INDIGO: shirt.Price += 0.7m; break;
                case Color.ORANGE: shirt.Price += 0.7m; break;
                case Color.RED: shirt.Price += 0.8m; break;
                case Color.VIOLET: shirt.Price += 0.2m; break;
                case Color.YELLOW: shirt.Price += 0.3m; break;
                default: break;
            }
        }
    }
}
