using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Objects
            Vehicle v1 = new Vehicle("black", 19, 36, 50);
            Vehicle v2 = new Vehicle("red", 19, 333, 90);
            //Price
            Console.WriteLine(v1.Price);
            Console.WriteLine("" + v1.UpdatePrice(89));
            Console.WriteLine(v1.Price);
            //Name
            Console.WriteLine(v1.Name);
            v1.Name = "Harald";
            Console.WriteLine(v1.Name);
            v1.Name = "hello";
            Console.WriteLine(v1.Name);
            

        }
    }
}
