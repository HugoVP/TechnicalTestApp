using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class BottomGarment: Wear
    {
        public int NumberOfPockets { get; set; }
        public int Size { get; set; }
        public enum BottomGarmentType { Pants, Short, Jean, Skirt }
    }
}
