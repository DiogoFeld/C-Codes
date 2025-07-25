using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.ComplexType
{
    public class NullLables
    {
        public void DoNull()
        {
            showString(null!);
            showString(null); 
            

            showPerson(null!);
            showPerson(new Person() { Age = 2});

            showString(null);
        }


        public void showString(string line)
        {
            Console.WriteLine(line);
        }

        public void showString2(string? line)
        {
            Console.WriteLine(line);
        }
        public void showPerson(Person person)
        {
            int age = person?.Age ?? 0;


            Console.WriteLine(age);
        }



    }
}
