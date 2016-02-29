using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NewVehicle : Vehicle
    {
        private static string name;
        private static double newHeight;
        private static double newWidth;
        private static decimal price;
        public decimal m_power;
        //Constructor
        public NewVehicle( decimal newPower ):
            base(name, newWidth, newHeight, price)
        {
           this.m_power = newPower;
        }

        //Methods
        public decimal SetPower(decimal newPower)
        {
            if (newPower < 0) throw new Exception("Power musst be greater then 20");
            else
                m_power = newPower;
            return m_power;
        }
    }
}
