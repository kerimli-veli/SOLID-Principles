using System;
namespace SOLID_Principles.Interface_Segregation.Principle
{

    //interface IVehicle
    //{
    //    void Refuel();  
    //    void Charge();  
    //}


    //class Car : IVehicle
    //{
    //    public void Refuel()
    //    {
    //        Console.WriteLine("Gasoline car got fuel!");
    //    }

    //    public void Charge()
    //    {
    //        throw new NotSupportedException("Gasoline car cannot be charged!");
    //    }
    //}


    //class ElectricCar : IVehicle
    //{
    //    public void Refuel()
    //    {
    //        throw new NotSupportedException("Electric car can't get fuel!");
    //    }

    //    public void Charge()
    //    {
    //        Console.WriteLine("The electric car is charged!");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        IVehicle myCar = new Car();
    //        myCar.Refuel();
    //        myCar.Charge(); 

    //        IVehicle tesla = new ElectricCar();
    //        tesla.Refuel(); 
    //        tesla.Charge();
    //    }
    //}



   
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
            Console.WriteLine("Gasoline car cannot be charged!");
        }
    }

    
    class ElectricCar : IElectricVehicle
    {
        public void Charge()
        {
            Console.WriteLine("The electric car is charged!");
        }
    }

    class Program
    {
        static void Main()
        {
            IFuelVehicle myCar = new Car();
            myCar.Refuel(); 

            IElectricVehicle tesla = new ElectricCar();
            tesla.Charge();
        }
    }





}
