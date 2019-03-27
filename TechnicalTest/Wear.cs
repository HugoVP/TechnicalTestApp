using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Wear
    {
        public string Trademark;
        public string Material;
        public string Color;
        public enum GenderWearType { Men, Women, Unisex }
        public GenderWearType GenderWear;
    }
}
