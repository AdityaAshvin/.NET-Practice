using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

public class DepartmentService : IDepartmentService
{
    private string? _departmentName;
    private InstructorService? _head;
    private decimal _budgetAmount;
    private DateTime _budgetStartDate;
    private DateTime _budgetEndDate;
    private List<string> _courses = new();

    public DepartmentService(string departmentName)
    {
        _departmentName = departmentName;
    }

    public void SetHead(InstructorService instructor)
    {
        _head = instructor;
        if (_departmentName != null)
        {
            instructor.Dept(_departmentName, true);
            Console.WriteLine($"{instructor.GetType().Name} assigned as head of {_departmentName}");
        }
    }

    public InstructorService GetHead()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("No Head of Department assigned.");
        }
        else
        {
            return _head;
        }
    }

    public void SetBudget(decimal amount, DateTime startDate, DateTime endDate)
    {
        if (amount < 0)
            throw new ArgumentException("Budget amount cannot be negative");

        if (endDate < startDate)
            throw new ArgumentException("End date cannot be before start date");

        _budgetAmount = amount;
        _budgetStartDate = startDate;
        _budgetEndDate = endDate;
    }

    public (decimal Amount, DateTime StartDate, DateTime EndDate) GetBudget()
    {
        return (_budgetAmount, _budgetStartDate, _budgetEndDate);
    }

    public void AddCourse(string courseName)
    {
        if (!_courses.Contains(courseName))
        {
            _courses.Add(courseName);
        }
    }

    public List<string> GetCourses()
    {
        return _courses;
    }

    public string GetDepartmentName()
    {
        if (_departmentName != null)
        {
            return _departmentName;
        }
        else
        {
            return "NA";
        }
    }
}
