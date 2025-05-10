using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Generics
{
    static class GenericsEx<T>
    {
        static void GenericExample(T example)
        {
            string f;
            
            Console.WriteLine(example.GetType());
            Console.WriteLine(example);
        }


        static void MethodExample<TExaple>()
        {

        }

        static void FunctionExampleRun()
        {
            List<Employee> listE = new List<Employee>
            {
            new Employee(),
            new Employee(),
            new Employee()
            };

            SortedList<Employee> sortedList = new SortedList<Employee>(listE);
        }

    }




    public class SortedList<T> where T : Employee, IComparable<T>//restring para o employee e IComparable
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }

    public class Employee : IComparable<Employee>
    {
        public int CompareTo(Employee? other)
        {
            throw new NotImplementedException();
        }
    }

    public class FullName : IComparable<FullName> // your code goes here
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public int CompareTo(FullName? other)
        {

            var result = LastName.CompareTo(other.LastName);
            if (result == 0)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            return result;
        }

        public override string ToString() => $"{FirstName} {LastName}";

        //your code hoes here
    }
}
