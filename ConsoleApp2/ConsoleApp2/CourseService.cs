using System;

public class CourseService : ICourseService
{
    private Dictionary<string, List<StudentService>> _courseStudents = new();

    public void AddCourse(string courseName)
    {
        if (!_courseStudents.ContainsKey(courseName))
        {
            _courseStudents[courseName] = new List<StudentService>();
            Console.WriteLine($"Course '{courseName}' added.");
        }
        else
        {
            Console.WriteLine($"Course '{courseName}' already exists.");
        }
    }

    public void EnrollStudent(string courseName, StudentService student)
    {
        if (!_courseStudents.ContainsKey(courseName))
        {
            Console.WriteLine($"Course '{courseName}' does not exist.");
            return;
        }

        if (!_courseStudents[courseName].Contains(student))
        {
            _courseStudents[courseName].Add(student);
            student.Enroll(courseName);  // updates student’s own enrollment
            Console.WriteLine($"Enrolled {student.Name} in course {courseName}");
        }
        else
        {
            Console.WriteLine($"{student.Name} is already enrolled in {courseName}");
        }
    }

    public List<string> GetStudents(string courseName)
    {
        var result = new List<string>();

        if (_courseStudents.ContainsKey(courseName))
        {
            foreach (var student in _courseStudents[courseName])
            {
                result.Add(student.Name);
            }
        }

        return result;
    }
}