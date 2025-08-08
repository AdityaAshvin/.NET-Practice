using System;

public class InstructorService : IInstructorService
{
    private List<string> _addresses;
    private string _department = "NA";
    private bool _isHead;
    public InstructorService(List<string> addresses)
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

    public List<String> GetAddress()
    {
        return _addresses;
    }

    public decimal GetBonus(DateTime joinDate)
    {
        DateTime today = DateTime.Now;
        int exp = today.Year - joinDate.Year;
        decimal bonus = 0;

        if (exp > 10)
        {
            bonus = 5000;
        }
        else if (exp > 5 && exp < 10)
        {
            bonus = 2500;
        }
        else
        {
            bonus = 500;
        }

        return bonus;
    }

    public decimal GetSalary(decimal baseSalary, decimal bonus)
    {
        decimal total = baseSalary + bonus;
        Console.WriteLine("the instructor's salary is {total}");
        return (total);
    }

    public void Dept(string departmentName, bool isHead)
    {
        _department = departmentName;
        _isHead = isHead;
    }

    public string GetDept()
    {
        return _department;
    }

    public bool IsHOD()
    {
        return _isHead;
    }
}