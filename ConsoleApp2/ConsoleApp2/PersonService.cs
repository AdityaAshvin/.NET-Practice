using System;

public class PersonService : IPersonService
{
    private List<string> _addresses;
    public PersonService(List<string> addresses)
    {
        _addresses = addresses;
    }

    public int GetAge(DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age))
        {
            age -= 1;
        }
        ;
        Console.WriteLine($"the age of the person is {age}");
        return age;
    }

    public decimal GetSalary(decimal BaseSalary, decimal comm)
    {
        if (BaseSalary < 0)
        {
            Console.WriteLine("base salary cannot be negative");
        }
        decimal salary = BaseSalary + comm;
        Console.WriteLine($"the person's salary is {salary}");
        return (salary);
    }

    public List<String> GetAddress()
    {
        return _addresses;
    }
}