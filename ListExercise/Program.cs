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

            Console.WriteLine("\n\n\n");




            // Dictionary Example
            Console.WriteLine("Dictionary Example:\n\n");


            Dictionary<int, Employee> dictEmps = new Dictionary<int, Employee>();
            dictEmps.Add(emp1.Id, emp1);
            dictEmps.Add(emp2.Id, emp2);
            dictEmps.Add(emp3.Id, emp3);

            //dictEmps.Add(emp1.Id, emp1);

            //Console.Write("\n\nEnter key: ");
            //int key = int.Parse(Console.ReadLine());

            //if (dictEmps.ContainsKey(key))
            //{
            //    Employee employee = dictEmps[key];
            //    Console.WriteLine(employee);
            //}
            //else
            //    Console.WriteLine("Invalid key. Please try again");


            foreach (var e in dictEmps)
            {
                int key = e.Key;
                Employee employee = e.Value;

                Console.WriteLine("Key = " + key);
                Console.WriteLine(employee);
            }



            // Stack example

            Console.WriteLine("\n\n\nStack Example\n\n");

            Stack<int> intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            //int num = intStack[1];

            Console.WriteLine("Number of items: " + intStack.Count);
            foreach (var i in intStack)
                Console.WriteLine(i);

            int num = intStack.Pop();   // remove 30
            Console.WriteLine("\n\nNum = " + num);
            Console.WriteLine("Number of items: " + intStack.Count);

            num = intStack.Peek();
            Console.WriteLine("\n\nNum = " + num);
            Console.WriteLine("Number of items: " + intStack.Count);




            // Queue Example

            Console.WriteLine("\n\n\nQueue Example\n\n");

            Queue<int> intQue = new Queue<int>();
            intQue.Enqueue(10);
            intQue.Enqueue(20);
            intQue.Enqueue(30);

            //num = intQue[1];

            Console.WriteLine("Number of items: " + intQue.Count);
            foreach (var i in intQue)
                Console.WriteLine(i);

            num = intQue.Dequeue();     // remove 10
            Console.WriteLine("\n\nNum = " + num);
            Console.WriteLine("Number of items: " + intQue.Count);

            num = intQue.Peek();
            Console.WriteLine("\n\nNum = " + num);
            Console.WriteLine("Number of items: " + intQue.Count);






            Console.WriteLine("\n\n\n");
        }
    }
}
