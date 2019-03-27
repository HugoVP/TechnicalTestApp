using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Shirt : Wear
    {
        public enum CollarType { Classic, Medium, Cutaway, ButtonDown }

        public int NumberOfPockets { get; set; }
        public int NumberOfButtons { get; set; }
        public int ChestSize { get; set; }
        public int Lenght { get; set; }
        public int SleeveSize { get; set; }
    }
}
