using System;

class Q3_d
{
    private int age;  // private variable (encapsulated)

    // Public method to set age
    public void SetAge(int a)
    {
        if (a >= 0)
        {
            age = a;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }

    // Public method to get age
    public int GetAge()
    {
        return age;
    }
}
