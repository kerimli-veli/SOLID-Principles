using System;
namespace SOLID_Principles.Liskov_substitution.Principle
{
    // public class Liskov_substitution { } Barbara Liskov


    //class Vehicle
    //{
    //    public virtual void Refuel()
    //    {
    //        Console.WriteLine("Araç yakıt aldı!");
    //    }
    //}

    //class Car : Vehicle
    //{
    //    public override void Refuel()
    //    {
    //        Console.WriteLine("Benzinli araba yakıt aldı!");
    //    }
    //}

    //class ElectricCar : Vehicle
    //{
    //    public override void Refuel()
    //    {
    //        throw new NotSupportedException("Elektrikli araba yakıt alamaz!");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Vehicle myCar = new Car();
    //        myCar.Refuel();

    //        Vehicle myElectricCar = new ElectricCar();
    //        myElectricCar.Refuel(); // BOOM! Hata verir.
    //    }
    //}


    ///////////////////////////////  
    ///


   

    interface IFuelVehicle
    {
        void Refuel();
    }

    interface IElectricVehicle
    {
        void Charge();
    }

    
    class Car : IFuelVehicle
    {
        public void Refuel()
        {
            Console.WriteLine("Gasoline fueled the car!");
        }
    }

   
    class ElectricCar : IElectricVehicle
    {
        public void Charge()
        {
            Console.WriteLine("Electric car charged!");
        }
    }

    class Program
    {
        static void Main()
        {
            IFuelVehicle myCar = new Car();
            myCar.Refuel();

            IElectricVehicle myElectricCar = new ElectricCar();
            myElectricCar.Charge();
        }
    }






}
