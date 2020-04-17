using Assignment3ThanosKatrakis.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3ThanosKatrakis.Strategies.ProductVariationStrategy
{
    interface VariationStrategy
    {
        void Cost(TeeShirt shirt);
    }
}
