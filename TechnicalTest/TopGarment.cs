using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class TopGarment: Wear
    {
        public int NumberOfPockets { get; set; }
        public int NumberOfButtons { get; set; }
        public enum SizeType { Small, Medium, Large, ExtraLarge }
        public SizeType Size;
        public enum TopGarmentType { Shirt, Coat, Jacket, Sweatshirt }
        public TopGarmentType Type;
    }
}
