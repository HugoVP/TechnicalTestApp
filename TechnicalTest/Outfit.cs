using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public struct Outfit
    {
        public TopGarment Top;
        public BottomGarment Bottom;
        public Footwear Footwear;


        override public string ToString()
        {
            
            return $"Top:       {Top},\n" +
                    $"Bottom:   {Bottom},\n" +
                    $"Footwear: {Footwear}";
            
        }
    }
}
