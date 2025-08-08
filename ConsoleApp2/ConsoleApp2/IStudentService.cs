using System;

public interface IStudentService : IPersonService
{
    public double GetGPA();
    public void Enroll(string courseName);
    public void Grade(string courseName, char grade);
}