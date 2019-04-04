using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Reflections.Employee");
            //OR

            //Type T = typeof(Employee);

            //OR

            Employee emp = new Employee(10,"john");
            Type T = emp.GetType();
           

            FieldInfo[] fields = T.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine("field type with name={0} \nfield type with name={1}   ", field.FieldType.Name,field.FieldType);

                Console.WriteLine("field name is {0} \ndeclaring type is {1}\n is public or not? {2}\n\n",field.Name, field.DeclaringType, field.IsPublic);

            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("{0}",property.PropertyType);
            }

        }
    }

    class Employee
    {
        //2 public fields
        public int empID;
        public string empName;

        //2 properties
        public int Id
        {
            get { return empID; }
            set { empID = value; }
        }

        public string Name
        {
            get {return empName; }
            set {empName = value; }
        }

        //2 ctor
        public Employee()
        {
            Id = -1;
            Name = string.Empty;
        }
        public Employee(int id,string name)
        {
            Id = id;
            Name = name;
        }


        //2 methods
        public void DisplayId()
        {
            Console.WriteLine("ID is {0}",this.Id);

        }

        public void DisplayName()
        {
            Console.WriteLine("Name is {0}", this.Name);

        }

    }
}
