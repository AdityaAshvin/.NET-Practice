using System;

public interface IDepartmentService
{
    void SetHead(InstructorService instructor);
    InstructorService GetHead();

    void SetBudget(decimal amount, DateTime startDate, DateTime endDate);
    (decimal Amount, DateTime StartDate, DateTime EndDate) GetBudget();

    void AddCourse(string courseName);
    List<string> GetCourses();

    string GetDepartmentName();
}