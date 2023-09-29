using System;

// Create an Employee class with Id, FirstName, and LastName properties.
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare two Employee objects based on their Id property.
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (ReferenceEquals(employee1, employee2))
            return true;

        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            return false;

        return employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator to complement the "=="
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }

    // Override the Equals method to provide additional comparison capabilities.
    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
            return false;

        Employee otherEmployee = (Employee)obj;
        return this.Id == otherEmployee.Id;
    }

    // Override the GetHashCode method to maintain consistency with the overridden Equals method.
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties.
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        Employee employee2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the two Employee objects using the overloaded operators.
        bool areEqual = (employee1 == employee2);
        bool areNotEqual = (employee1 != employee2);

        // Display the results.
        Console.WriteLine($"Employee 1 and Employee 2 are equal: {areEqual}");
        Console.WriteLine($"Employee 1 and Employee 2 are not equal: {areNotEqual}");

        Console.ReadKey();
    }
}

