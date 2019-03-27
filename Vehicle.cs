using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation
{
    public enum EngineType
    {
        Diesel,
        Gas
    };

    public enum Brand
    {
        BMW, Renault, Mercedes, Audi, Ferrari
    }

    class Vehicle
        //class try 
    {
        public Vehicle(){ }

        protected EngineType _engine;
        protected double _speed=150;
        protected double _mileage;


        public EngineType engine        //New Comment
        {
            get;
            set; 
        }

        public double mileage           //DONE
        {
            get; set;
        }
        
        public double speed             //DONE
        {
            get { return _speed; }
            set
            {
                if (value <= 0)
                {
                    _speed = 0;
                }
                else if (value >= 300)
                {
                    _speed = 300;
                }
                else
                {
                    _speed = value;
                }
            }
        }


        public void Accelerate(double kmph)
        {
            speed += kmph;
        }

        public void Decelerate(double kmph)
        {
            speed -= kmph;
        }

        public virtual void Print()
        {
            
            Console.WriteLine("Engine: " + engine);
            Console.WriteLine("Speed: "+ speed +" kmph");
            Console.WriteLine("Mileage: " + mileage + " km");

        }
    }

    

    class Car : Vehicle
    {   public Brand brand
        {
            get; set;
        }

        public override void Print()
        {
            Console.WriteLine("         Car");
            Console.WriteLine("Brand: " + brand);
            base.Print();
            
        }
    }

    class Bus : Vehicle
    {
        protected double _seats = 50;
        public double seats
        {
            get { return _seats; }
            set
            {  if (value <= 12)
                    _seats = 12;
                else if (value >= 50)
                    _seats = 50;
                else
                    _seats = value;
            }


        }

        public override void Print()
        {
            Console.WriteLine("         Bus");
            base.Print();
            Console.Write("A number of seats: " + seats);
        }


    }
}
