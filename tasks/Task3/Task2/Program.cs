using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using static System.Console;
using System.Drawing;
using System.Reactive.Linq;
using System.Windows.Forms;
using System.Threading;

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
                Console.WriteLine("Vehicle: Name und Price von Vehicle {0} --> {1} -->{2}", i, myarray[i].Name, myarray[i].Price);
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


            ///<summary>
            /// Pull
            ///</summary>
            
            WriteLine("enumerables: foreach (array)");
            IEnumerable<Vehicle> vehicles = new Vehicle[] { v1, v2, v3, v4 };
            foreach (var v in vehicles) Write(v.Name + " "); WriteLine();

            WriteLine("enumerables: foreach (list)");
            vehicles = new List<Vehicle> {v1, v2, v3, v4};
            foreach (var v in vehicles) Write(v.Price + " "); WriteLine();

            WriteLine("enumerables: behind the scenes");
            var e = vehicles.GetEnumerator();
            while (e.MoveNext()) Write(e.Current.MotorPover + " "); WriteLine();

            WriteLine("enumerables: queries (filter) - Where(vehicle price => x / 2 > 200)");
            var v_filter = vehicles.Where(x => x.Price + 100 > 1000);
            foreach (var y in v_filter) Write(y + " "); WriteLine();

            WriteLine("enumerables: queries (map) - Select(x => x * x)");
            //v_filter = vehicles.Select();

            //foreach (var y in ys) Write(y + " "); WriteLine();

            ///<summary>
            /// Push
            ///</summary>
            var w = new Form() { Text = "Push Example", Width = 800, Height = 600 };
            //w.MouseMove += (s, e) => WriteLine($"[MouseMove event] ({e.X}, {e.Y})");

            // Rx observables
            IObservable<Point> moves = Observable.FromEventPattern<MouseEventArgs>(w, "MouseMove").Select(x => x.EventArgs.Location);

            //moves
            //    .Subscribe(e => WriteLine($"[A] ({e.X}, {e.Y})"))
            //    ;

            //moves
            //    .DistinctUntilChanged()
            //    .Subscribe(e => WriteLine($"[B] ({e.X}, {e.Y})"))
            //    ;

            //moves
            // C# events

            //    .Sample(TimeSpan.FromSeconds(1))
            //    .DistinctUntilChanged()
            //    .Subscribe(e => WriteLine($"[C] ({e.X}, {e.Y})"))
            //    ;

            moves
                
                .Throttle(TimeSpan.FromSeconds(0.2))
                .DistinctUntilChanged()
                .Subscribe(b => WriteLine($"[D] ({b.X}, {b.Y})"))
                ;
            ///<summary>
            /// Threading
            ///</summary>
          
            Thread t_1 = new Thread(Incrementer);
            Thread t_2 = new Thread(Decrementer);

            // Threads starten
            t_1.Start(0);
            t_2.Start(100);
            Application.Run(w);
        }

        public static void Incrementer(object o)
        {
            for (int i = Convert.ToInt32(o); i < 100; i++)
            {
                Console.WriteLine("Incrementer: {0}", i);
            }
        }

        public static void Decrementer(object o)
        {
            for (int i = Convert.ToInt32(o); i >= 0; i--)
            {
                Console.WriteLine("Decrementer: {0}", i);
            }
        }
    }
}
