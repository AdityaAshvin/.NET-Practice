using System;

public interface IPersonService
{
    int GetAge(DateTime birthdate);
    decimal GetSalary(decimal BaseSalary, decimal comm = 0);
    List<string> GetAddress();
}