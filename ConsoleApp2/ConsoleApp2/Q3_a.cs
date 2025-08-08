using System;

class Q3_a
{
    public static void Inheritance()
    {
        Car myCar = new Car();
        myCar.Move();
        Console.WriteLine($"The vehicle is a {myCar.modelname} of company {myCar.companyName}");

        Truck myTruck = new Truck();
        myTruck.Move();
        Console.WriteLine($"The vehicle is a {myTruck.modelname} of company {myTruck.companyName}");
    }
}

class Vehicle
{
    public String companyName = "Mercedes";

    public void Move()
    {
        Console.WriteLine("The vehicle moves");
    }
}

class Car : Vehicle
{
    public String modelname = "C class";
}

class Truck : Vehicle
{
    public String modelname = "Truck";
}