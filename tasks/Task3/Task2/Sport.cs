using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    public class Sport : Vehicle
    {

        private double m_Power;
        private static string newColor;
        private static double newHeight;
        private static string newName;
        private static decimal newPrice;
        private static string newType;
        private static double newWidth;
        private static int newPower;
        private static int newPover;


        //Constructor
        public Sport( double new_Power)
            :base(newName,  newColor,  newType, newPover,  newPrice,  newWidth,  newHeight)
        {
           this.m_Power = newPower;
        }

        //Methods
        public double SetPower(double newPower)
        {
            if (newPower < 0)
            {
                throw new Exception("Power musst be greater then 20");
            }
            else
            {
                m_Power = newPower;
                return m_Power;
            }
        }
    }
}
