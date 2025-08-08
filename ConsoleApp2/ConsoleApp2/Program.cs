class Program
{
    static void Main(string[] args)
    {
        // 1. Create Instructor and assign to department
        var instructorAddresses = new List<string> { "123 Faculty Lane" };
        var instructor = new InstructorService(instructorAddresses);
        var department = new DepartmentService("Computer Science");
        department.SetHead(instructor);
        department.SetBudget(1000000m, new DateTime(2025, 1, 1), new DateTime(2025, 12, 31));

        // 2. Create Courses
        var course1 = "Data Structures";
        var course2 = "Algorithms";
        department.AddCourse(course1);
        department.AddCourse(course2);

        // 3. Create Student
        var addresses = new List<string> { "Los Angeles", "Arizona", "Irvine" };
        var student = new StudentService("Alice", addresses);
        student.Enroll(course1);
        student.Enroll(course2);
        student.Grade(course1, 'A');
        student.Grade(course2, 'B');

        // 4. Show Department Info
        Console.WriteLine("\n--- Department Info ---");
        Console.WriteLine($"Department: {department.GetDepartmentName()}");
        Console.WriteLine($"Head: {(department.GetHead() != null ? instructor.GetType().Name : "No head assigned")}");
        var budget = department.GetBudget();
        Console.WriteLine($"Budget: {budget.Amount:C} ({budget.StartDate.ToShortDateString()} to {budget.EndDate.ToShortDateString()})");

        Console.WriteLine("\nCourses Offered:");
        foreach (var course in department.GetCourses())
        {
            Console.WriteLine($"- {course}");
        }

        // 5. Show Student Info
        Console.WriteLine("\n--- Student Info ---");
        Console.WriteLine($"Student: {student.Name}");
        Console.WriteLine("Courses & Grades:");
        foreach (var course in student.GetCourses())
        {
            var courseName = course.Key;
            string grade = course.Value.HasValue ? course.Value.Value.ToString() : "Not graded";
            Console.WriteLine($"- {course.Key}: {grade}");
        }

        Console.WriteLine($"GPA: {student.GetGPA():F2}");
    }
}

/*
Working with methods
*/

// Q1.Reverse(12);

// Q2.Fibonnaci(10);

/*
Designing and Building Classes using object-oriented principles
*/

//Q3_a.Inheritance();
//Q3_b.Polymorphism();
//Q3_c.Abstraction();