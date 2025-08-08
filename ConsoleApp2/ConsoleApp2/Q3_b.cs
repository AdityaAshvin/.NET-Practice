using System;

class Q3_b
{
    public static void Polymorphism()
    {
        Fruit myFruit = new Fruit();
        Apple myApple = new Apple();
        Mango myMango = new Mango();

        myFruit.FruitColor();
        myApple.FruitColor();
        myMango.FruitColor();
    }
}

class Fruit
{
    public virtual void FruitColor()
    {
        Console.WriteLine("Color of the fruit");
    }
}

class Apple : Fruit
{
    public override void FruitColor()
    {
        Console.WriteLine("Apple is red in color");
    }
}

class Mango : Fruit
{
    public override void FruitColor()
    {
        Console.WriteLine("Mango is yellow in color");
    }
}