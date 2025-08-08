using System;

public class StudentService : IStudentService
{
    private List<string> _addresses;
    public string Name { get; private set; }
    public StudentService(string name, List<string> addresses)
    {
        Name = name;
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

    private Dictionary<string, char?> _courses = new();

    public void Enroll(string courseName)
    {
        if (_courses.ContainsKey(courseName) == false)
        {
            _courses[courseName] = null;
        }
    }

    public void Grade(string courseName, char grade)
    {
        if (_courses.ContainsKey(courseName) == false)
        {
            Console.WriteLine("the student is not enrolled in the given course. Grade could not be added");
        }
        else
        {
            _courses[courseName] = grade;
        }
    }
    public Dictionary<string, char?> GetCourses()
    {
        return _courses;
    }

    public double GetGPA()
    {
        double total = 0.0;
        int courses = 0;
        foreach (var course in _courses)
        {
            if (course.Value.HasValue)
            {
                total += course.Value.Value switch
                {
                    'A' => 4.0,
                    'B' => 3.0,
                    'C' => 2.0,
                    'D' => 1.0,
                    'E' => 0.5,
                    'F' => 0.0,
                    _ => 0.0
                };
                courses += 1;
            }
        }
        double gpa = total / courses;
        Console.WriteLine($"your gpa is {gpa}");
        return gpa;
    }
}