using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IVehicle
    {
        string Name { get; set; }
        decimal Price { get; set; }
        string Color { get; set; }
        string Type { get; set; }

        string Describe(string describe);
        decimal UpdatePrice(decimal newPrice);
        decimal OldPrice(decimal oldPrice);


        //public int[] Vehicles { get; set; }
        //IEnumerable<int> IVehicle.Vehicles
        //{
        //    get
        //    {
        //        return this.Vehicles;
        //    }
        //    set { }
        //}
    }
}
