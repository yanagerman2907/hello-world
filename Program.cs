using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle tachka = new Vehicle();
            tachka.engine = EngineType.Diesel;
            tachka.mileage = 4000;
            tachka.Print();

            // 
            Console.WriteLine();
            Console.WriteLine();
            //

            Car beha = new Car();
            beha.brand = Brand.BMW;
            beha.engine = EngineType.Gas;
            beha.mileage = 5000;
            
            beha.Print();
            Console.Write("New speed: ");

            beha.Accelerate(500);
            Console.Write(beha.speed);

            // 
            Console.WriteLine();
            Console.WriteLine();
            //

            Bus busik = new Bus();
            busik.engine = EngineType.Gas;
            busik.mileage = 8000;
            busik.seats = 400;
            busik.Print();

            Console.WriteLine();
        }

    }
}
