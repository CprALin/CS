using System.Collections;

namespace ConsoleApp7
{
    internal class Program
    {
        //key - value

        static void Main(string[] args)
        {
            // hashFirstEx();
            // hashTwoEx();
            employeeTest();
        }

        public static string disctionary(int i)
        {
            Dictionary<int,string> myDic = new Dictionary<int,string>()
            {
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"five"}
            };

            if(myDic.ContainsKey(i))
            {
                return myDic[i];
            }
            else
            {
                Console.WriteLine("nope");
            }

            return myDic[i];
        }

        public static void hashTwoEx()
        {
            Student[] students = new Student[5];

            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luis", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsTable.ContainsKey(student.Id))
                {
                    studentsTable.Add(student.Id, student);
                    Console.WriteLine($"Student with id {student.Id} was added!");
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same ID already exists.");
                }
            }
        }

        public static void hashFirstEx()
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "Ana", 98);
            Student student2 = new Student(2, "Andrei", 89);
            Student student3 = new Student(3, "Alex", 60);
            Student student4 = new Student(4, "Anca", 79);

            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            // retrieve individual item with know ID
            Student storeStudent1 = (Student)studentsTable[1];

            //retrieve all values from a hashtable
            //foreach(DictionaryEntry entry in studentsTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine($"Student ID: {temp.Id}");
            //    Console.WriteLine($"Student Name: {temp.Name}");
            //    Console.WriteLine($"Student GPA: {temp.GPA}");
            //}

            ///  Console.WriteLine($"Student id : {storeStudent1.Id} | Student Name : {storeStudent1.Name} | Student GPA : {storeStudent1.GPA}");

            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {student.Id}");
                Console.WriteLine($"Student Name: {student.Name}");
                Console.WriteLine($"Student GPA: {student.GPA}");
            }
        }

        public static void employeeTest()
        {
            Employee[] employees =
            {
                new Employee("CEO" , "Alex" , 40 , 200),
                new Employee("Manager" , "Andra" , 30 , 35),
                new Employee("HR" , "Lora" , 25 , 21),
                new Employee("Secretary", "Petra" , 23 , 18),
                new Employee("Lead Developer", "Andrew", 55,35),
                new Employee("Intern" , "Alin" , 20 , 8)
            };

            Dictionary<string, Employee> employeeDic = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeeDic.Add(emp.Role, emp);
            }

            //update a dictionary
            string keyToUpdate = "HR";
            if(employeeDic.ContainsKey(keyToUpdate))
            {
                employeeDic[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine($"Employee with Role/Key {keyToUpdate} was updated!");
            }
            else
            {
                Console.WriteLine($"No employee found with this key {keyToUpdate}");
            }

            //remove a dictionary
            string keyToRemove = "Intern";
            if(employeeDic.Remove(keyToRemove))
            {
                Console.WriteLine($"Employee with role/key {keyToRemove} was removed!");
            }
            else
            {
                Console.WriteLine($"No employee found with this key {keyToRemove}");
            }

            string key = "CEO";
            if( employeeDic.ContainsKey(key) )
            {
                Employee empl = employeeDic["CEO"];
                Console.WriteLine($"Employee Name : {empl.Name} | Role : {empl.Role} | Salary : {empl.salary}");
            }
            else
            {
                Console.WriteLine($"No employee found with this key {key} !");
            }

            Employee result = null;
            if(employeeDic.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine($"Employee Name : {result.Name} | Role : {result.Role} | Salary : {result.salary}");
            }
            else
            {
                Console.WriteLine($"The key does not exist!");
            }

            for(int i = 0; i < employeeDic.Count; i++)
            {
                KeyValuePair<string,Employee> keyValuePair = employeeDic.ElementAt(i);

                Employee empl = keyValuePair.Value;

                Console.WriteLine($"Employee Name : {empl.Name} | Role : {empl.Role} | Salary : {empl.salary}");
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int Id, string Name, float GPA)
        {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        //early salary = rate/h * number of days * number of weeks * number of months
        public float salary
        {
            get
            {
                return this.Rate * 8 * 5 * 4 * 12;
            }
        }

        //simple constructor
        public Employee(string Role , string Name , int Age, float Rate)
        {
            this.Role = Role;
            this.Name = Name;
            this.Age = Age;
            this.Rate = Rate;
        }

    }
}