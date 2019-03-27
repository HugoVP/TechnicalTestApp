using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Person
    {
        public enum GenderType { Male, Female };
        
        public string FirstName;
        public string LastName;

        public float Weight;
        public float Height;

        public GenderType Gender;

        public DateTime Birthdate;

        private Outfit? Outfit;

        override public string ToString()
        {
            return $"FirstName: {FirstName},\n" +
                   $"Gender:    {Gender},\n" +
                   $"Height:    {string.Format("{0:0.00}", Height)},\n" +
                   $"Weight:    {Weight.ToString("0.00")},\n" +
                   $"Birthdate: {Birthdate.ToShortDateString()}";
        }

        public void GetDressed(Outfit outfit)
        {
            Outfit = outfit;
        }

        public Outfit? GetOutfit()
        {
            return Outfit;
        }
    }
}
