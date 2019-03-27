using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Footwear: Wear
    {
        public int Size { get; set; }
        public enum FootwearType { Sandals, Boots, Sneakers, FlipFlops, Moccasin, Brogues }
    }
}
