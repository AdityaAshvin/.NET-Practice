using System;

public class Product : Entity
{
    public string Name { get; set; } = "";
}

class Program
{
    static void Main(string[] args)
    {
        // ----- Question 1 -----
        MyStack<int> myStack = new MyStack<int>();

        myStack.Push(10);
        Console.WriteLine($"The length of the stack is now = {myStack.Count()}");
        myStack.Push(20);
        Console.WriteLine($"The length of the stack is now = {myStack.Count()}");
        myStack.Push(30);
        Console.WriteLine($"The length of the stack is now = {myStack.Count()}");
        myStack.Pop();
        Console.WriteLine($"The length of the stack is now = {myStack.Count()}");

        // ----- Question 2 -----
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        Console.WriteLine(myList.Contains(10));
        Console.WriteLine(myList.Contains(15));

        myList.Remove(1);

        Console.WriteLine(myList.Contains(10));
        Console.WriteLine(myList.Contains(15));
        Console.WriteLine(myList.Contains(20));

        myList.Clear();

        Console.WriteLine(myList.Contains(10));
        Console.WriteLine(myList.Contains(15));
        Console.WriteLine(myList.Contains(20));

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        myList.InsertAt(5, 0);
        myList.Add(10);

        Console.WriteLine(myList.Contains(10));
        Console.WriteLine(myList.Contains(5));
        Console.WriteLine(myList.Contains(20));

        myList.DeleteAt(0);

        Console.WriteLine(myList.Contains(10));
        Console.WriteLine(myList.Contains(5));
        Console.WriteLine(myList.Contains(20));

        Console.WriteLine(myList.Find(3));

        // ----- Question 3 -----
        IRepository<Product> repo = new GenericRepository<Product>();

        repo.Add(new Product { Id = 1, Name = "Apple" });
        repo.Add(new Product { Id = 2, Name = "Mango" });

        foreach (var p in repo.GetAll())
        {
            Console.WriteLine($"{p.Id} - {p.Name}");
        }

        var product = repo.GetById(1);
        if (product != null)
        {
            Console.WriteLine("Found: " + product.Name);
            repo.Remove(product);
            repo.Save();
        }
    }
}
