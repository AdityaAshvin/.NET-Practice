using System;

public interface ICourseService
{
    public List<string> GetStudents(string courseName);
    public void EnrollStudent(string _courseName, StudentService studentName);
    public void AddCourse(string courseName);
}