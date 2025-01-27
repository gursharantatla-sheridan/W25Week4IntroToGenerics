namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            List<Employee> employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            employees.Insert(1, emp3);
            employees.Remove(emp3);
            //employees.Clear();

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            // searching 

            // IndexOf()
            int index = employees.IndexOf(emp2);

            if (index >= 0)
                Console.WriteLine("Item found");
            else
                Console.WriteLine("Item not found");


            // Contains()
            if (employees.Contains(emp2))
                Console.WriteLine("Item found");
            else
                Console.WriteLine("Item not found");


            // Exists()

            if (employees.Exists(e => e.Name.StartsWith("A")))
                Console.WriteLine("Item found");
            else
                Console.WriteLine("Item not found");


            // Find()

            var em = employees.Find(e => e.Salary > 6000);

            if (em != null)
                Console.WriteLine(em);
            else
                Console.WriteLine("Employee not found");
        }
    }
}
