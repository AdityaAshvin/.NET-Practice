using System;
using System.Runtime.InteropServices;

class Q3_c
{
    public static void Abstraction()
    {

        Payment myPayment = new CreditCard();
        myPayment.MakePayment();
        myPayment.Success();

        myPayment = new CashApp();
        myPayment.MakePayment();
        myPayment.Success(); 

    }
}

abstract class Payment
{
    public abstract void MakePayment();

    public void Success()
    {
        Console.WriteLine("the payment was succesfull");
    }
}

class CreditCard : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("credit card used to make transaction");
    }
}

class CashApp : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Cash app used to make transaction");
    }
}