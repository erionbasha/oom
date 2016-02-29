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

            Action<string> Message = Console.WriteLine;
            Message("Das ist ein Message vom Action: " + v1.Name);
            Vehicle v1_2 = new Vehicle("red", 17, 222, 89);
            NewVehicle v1_3 = new NewVehicle(200);
            BigVehicle v1_4 = new BigVehicle(45);
            Console.WriteLine(v1_3.m_power);
            Console.WriteLine(v1_3.m_volume);


        }


    }
}
