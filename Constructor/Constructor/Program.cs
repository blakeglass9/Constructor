using System;

namespace ChainedConstructorsApp
{
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Define a constant variable. This value cannot be changed once set.
            const string appName = "Chained Constructors Demo";

            // Define a variable using the "var" keyword. The type is inferred based on the assigned value.
            var userGreeting = "Welcome to " + appName;

            // Display the greeting message to the console.
            Console.WriteLine(userGreeting);

            // Create an instance of the User class using the parameterized constructor.
            User user = new User("Alice", 25);

            // Display the user information.
            user.DisplayInfo();

            Console.ReadLine(); // Wait for user to press Enter before closing the application.
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor that initializes default values.
        public User() : this("Unknown", 0)
        {
            // Chained constructor. This constructor calls the one below with default values.
        }

        // Parameterized constructor that sets Name and Age based on input.
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display user information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
