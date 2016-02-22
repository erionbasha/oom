using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Vehicle
    {
        //Fields 
        private double width, height;
        private string m_name;

        public decimal m_price;

        //Constructor
        public Vehicle( string name, double newWidth, double newHeight, decimal price)
        {
            if (newWidth == 20) throw new Exception("Width musst be greater then 20");
            if (newHeight == 20) throw new Exception("Height musst be lower then 20");
            this.width = newWidth;
            this.height = newHeight;
            this.m_name = name;
            this.m_price = price;
        }

        //Properties Price
        public decimal Price
        {
            get
            {
                return m_price;
            }
            set
            {
                if (value < 0) throw new Exception("There is no Vehicle to GIFT !!!");
                m_price = value;
            }
        }

        //Properties Name
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }

        }

        //Methods
        public decimal UpdatePrice( decimal newPrice )
        {
            if (newPrice < 0) throw new Exception("Price musst be greater then 20");
            else
                m_price = newPrice;
            return m_price;
        } 
    }
}
