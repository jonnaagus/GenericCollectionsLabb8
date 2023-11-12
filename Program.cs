namespace GenericCollectionsLabb8
{
    // Elev: Jonna Gustafsson
    // Klass: .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - Stack
            Stack<Employee> employeeStack = new Stack<Employee>();

            Employee employee1 = new Employee(20, "Alice", "Female", 50000.0);
            Employee employee2 = new Employee(159, "David", "Male", 60000.0);
            Employee employee3 = new Employee(122, "Charlie", "Male", 70000.0);
            Employee employee4 = new Employee(140, "Paul", "Male", 80000.0);
            Employee employee5 = new Employee(13, "Helena", "Female", 90000.0);

            // Add the objects to the stack
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            // Print all objects in the stack
            Console.WriteLine("Objekt i stacken:");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            Console.WriteLine("------------------------------------------------------------");

            // Retrieve and print all objects using the Pop method
            Console.WriteLine("\nHämta alla objekt med Pop-metoden:");
            while (employeeStack.Count > 0)
            {
                Employee poppedEmployee = employeeStack.Pop();
                Console.WriteLine(poppedEmployee);
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
            }

            // Add all objects again using the Push method
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("------------------------------------------------------------");

            // Retrieve two objects using the Peek method
            Console.WriteLine("\nHämta två objekt med Peek-metoden:");
            for (int i = 0; i < 2; i++)
            {
                Employee peekedEmployee = employeeStack.Peek();
                Console.WriteLine(peekedEmployee);
                Console.WriteLine($"Antal objekt i stacken: {employeeStack.Count}");
                employeeStack.Pop(); // Remove the top object
            }

            // Check if object number 3 exists in the stack or not
            Employee employeeToFind = employee3;
            bool containsEmployee3 = employeeStack.Contains(employeeToFind);
            Console.WriteLine($"\nInnehåller stacken objekt nummer 3? {containsEmployee3}");

            Console.WriteLine("------------------------------------------------------------");

            // Part 2 - List
            List<Employee> employeeList = new List<Employee>();

            // Add five objects to the list
            Employee employee6 = new Employee(55, "Birgitta", "Female", 57000.0);
            Employee employee7 = new Employee(90, "Kalle", "Male", 62000.0);
            Employee employee8 = new Employee(109, "Henrik", "Male", 79000.0);
            Employee employee9 = new Employee(111, "Peter", "Male", 85000.0);
            Employee employee10 = new Employee(100, "Katarina", "Female", 99000.0);

            employeeList.Add(employee6);
            employeeList.Add(employee7);
            employeeList.Add(employee8);
            employeeList.Add(employee9);
            employeeList.Add(employee10);

            // Check if a specific object exists in the list using the Contains method
            if (employeeList.Contains(employee7))
            {
                Console.WriteLine("Employee7 objektet existerar i listan!");
            }
            else
            {
                Console.WriteLine("Employee7 objektet existerar inte i listan!");
            }

            Console.WriteLine("------------------------------------------------------------");

            // Use the Find method to find the first object in the list with Gender = "Male"
            Employee firstMaleEmployee = employeeList.Find(e => e.Gender == "Male");
            if (firstMaleEmployee != null)
            {
                Console.WriteLine("Första manliga anställda:");
                Console.WriteLine(firstMaleEmployee);
            }
            else
            {
                Console.WriteLine("Ingen manlig anställd hittades i listan!");
            }

            Console.WriteLine("------------------------------------------------------------");

            // Use the FindAll method to find and print all male employees in the list
            List<Employee> maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
            if (maleEmployees.Count > 0)
            {
                Console.WriteLine("\nAlla manliga anställda:");
                foreach (var maleEmployee in maleEmployees)
                {
                    Console.WriteLine(maleEmployee);
                }
            }
            else
            {
                Console.WriteLine("Inga manliga anställda hittades i listan!");
            }

            Console.WriteLine("------------------------------------------------------------");
        }
    }
}