using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BigVehicle : Vehicle
    {
        private static double newHeight;
        private static double newWidth;
        private static decimal price;
        double m_power;
        public BigVehicle(double power):base(name, newWidth, newHeight, price)
        {
            m_power = power;
        }

        public static string name { get; private set; }
    }
}
