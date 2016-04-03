using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Truck : Vehicle
    {
        //Fields 
        private double m_NumberOfWheels;
        private double m_TankFuel;
        private decimal m_Priece;

        private static string newName;
        private static string newColor;
        private static string newType;
        private static int newPover;

        private static double newWidth;
        private static decimal newPrice;
        private static double newHeight;


        //Constructor
        public Truck(double NumberOfWheels, double TankFuel)
             : base(newName, newColor, newType, newPover, newPrice, newWidth, newHeight)
        {
            m_NumberOfWheels = NumberOfWheels;
            m_TankFuel = TankFuel;
        }

        

        public static string TruckName
        {
            get;
            set;
        }

        public double TankFuel { get; private set; }
        public double NumberOfWheels { get; private set; }

        //Methods
        public new decimal UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new Exception("Price musst be greater then 200");
            }
            else
            {
                m_Priece = newPrice * (decimal)0.2;
            }
            return m_Priece;
        }
    }
}
