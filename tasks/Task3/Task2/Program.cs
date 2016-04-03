using Newtonsoft.Json;
using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Create some Objects of Type Vehicle.
            ///</summary>
            Vehicle v1 = new Vehicle("VW Polo", "Red", "Vehicle", 90, 12000, 2.4, 1.2);
            Vehicle v2 = new Vehicle("Opel", "Green", "Vehicle", 120, 16000, 2.4, 1.2);
            Vehicle v3 = new Vehicle("Fiat", "Blue", "Vehicle", 130, 12600, 2.4, 1.2);
            Vehicle v4 = new Vehicle("Honda", "White", "Vehicle", 75, 19000, 2.4, 1.2);

            /// <summary>
            /// Create some Objects of Type Truck.
            ///</summary>
            Truck t1 = new Truck(12, 100);

            //Print Name, Price and Power of Vehicle v1
            Console.WriteLine("Name: {0} Price: {1} Motor Power: {2}", v1.Name, v1.Price, v1.MotorPover);
            
            // Update Price von Vehicle v1.
            v1.UpdatePrice(15000);
            Console.WriteLine("Name: {0} New Price: {1}", v1.Name, v1.Price, v1.MotorPover);

            Vehicle[] myarray = { v1, v2, v3, v4 };
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine("Vehicle: Name und Price von Vehicle {0} --> {1} -->{2}",i, myarray[i].Name, myarray[i].Price);
            }

            IVehicle[] imyarray = { v1, v2, v3, v4 };
            for (int i = 0; i < imyarray.Length; i++)
            {
                Console.WriteLine("IVehicle: Name und Price von Vehicle {0} --> {1} -->{2}", i, myarray[i].Name, myarray[i].Price);
            }

            /// <summary>
            /// Serialize Array with Object.
            ///</summary>
            string s = JsonConvert.SerializeObject(v1);
            Console.WriteLine(s);

            for (int i = 0; i < imyarray.Length; i++)
            {
                {
                    string mystr = JsonConvert.SerializeObject(imyarray[i]);
                    File.AppendAllText("C:\\Vehicle.txt", mystr + "\n");
                }
            }

            /// <summary>
            /// Deserialize Array with Object.
            ///</summary>
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\\Vehicle.txt");
            while ((line = file.ReadLine()) != null)
            {
                object v = JsonConvert.DeserializeObject(line);
                System.Console.WriteLine(v);
                counter++;
            }
            file.Close();
        }
    }
}
