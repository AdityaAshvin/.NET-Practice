using System;

public interface IInstructorService : IPersonService
{
    public decimal GetBonus(DateTime joinDate);
    public void Dept(string deptName, bool isHOD);
    public bool IsHOD();
    public string GetDept();
}