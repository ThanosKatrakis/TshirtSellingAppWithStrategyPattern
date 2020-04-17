using Assignment3ThanosKatrakis.Enumerations;
using Assignment3ThanosKatrakis.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3ThanosKatrakis.Strategies.ProductVariationStrategy
{
    class FabricVariation : VariationStrategy
    {
        public void Cost(TeeShirt shirt)
        {
            switch (shirt.Fabric)
            {
                case Fabric.CASMERE: shirt.Price += 0.5m; break;
                case Fabric.COTTON: shirt.Price += 0.6m; break;
                case Fabric.LINEN: shirt.Price += 0.9m; break;
                case Fabric.POLYESTER: shirt.Price += 0.8m; break;
                case Fabric.RAYON: shirt.Price += 0.7m; break;
                case Fabric.SILK: shirt.Price += 1.1m; break;
                case Fabric.WOOL: shirt.Price += 1.5m; break;
                default: break;
            }
        }
    }
}
