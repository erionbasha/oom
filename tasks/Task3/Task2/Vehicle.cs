using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task2
{
    public class Vehicle : IVehicle
    {
        //Fields 
        private string m_name;
        private string m_color;
        private string m_type;
        private decimal m_price;
        private double m_width;
        private double m_height;
        private int m_power;


        //Constructor
        public Vehicle( string newName, string newColor, string newType,
                        int newPover, decimal newPrice, double newWidth, double newHeight)
        {
            if (newWidth == 20)
            {
                throw new Exception("Width musst be greater then 20");
            }
            if (newHeight == 20)
            {
                throw new Exception("Height musst be lower then 20");
            }
            this.m_width = newWidth;
            this.m_height = newHeight;
            this.m_name = newName;
            this.m_price = newPrice;
        }

        /// <summary>
        /// Name.
        ///</summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        internal int VehiclePrice(int v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Price.
        ///</summary>
        public decimal Price
        {
            get { return m_price; }
            set
            {
                if (value < 0) throw new Exception("There is no Vehicle to GIFT !!!");
                m_price = value;
            }
        }
        /// <summary>
        /// Motor Power.
        ///</summary>
        public int MotorPover
        {
            get { return m_power; }
            set
            {
                //throw new NotImplementedException();
                if (m_power > 50 || m_power < 1000)
                {
                    Console.WriteLine(" The Power of Vehicle musst be betwen 50 and 1000");
                }
                else
                {
                    m_power = value;
                }
            }
        }

        /// <summary>
        /// Color.
        ///</summary>
        public string Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        /// <summary>
        /// Describe.
        ///</summary>
        public string Describe(string describe)
        {
            if (describe == "")
            {
                throw new Exception("Decribe does not be Empty");
            }
            return describe;
        }

        /// <summary>
        /// Update Price.
        ///</summary>
        public decimal UpdatePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new Exception("Price musst be greater then 20");
            }
            else
            {
                m_price = newPrice;
            }
            return m_price;
        }

        /// <summary>
        /// Old Price.
        ///</summary>
        public decimal OldPrice(decimal oldPrice)
        {
            return m_price / 3;
        }

        /// <summary>
        /// Type.
        ///</summary>
        public string Type
        {
            get { return m_type; }
            set { m_type = value; }
        }

        public int[] Vehicles { get; set; }
       // IEnumerable<int> IVehicle. { get { return this.Vehicles; } set { } }

       public static R[] Map<T, R>(T[] data, Func<T, R> computation)
        {
            var result = new R[data.Length];
            for (var i = 0; i < data.Length; i++)
            {
                result[i] = computation(data[i]);
            }
            return result;
        }
    }
}
