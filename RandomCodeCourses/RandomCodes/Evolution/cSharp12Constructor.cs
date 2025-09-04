using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Evolution
{
    internal class cSharp12Constructor
    {
        Bird bird = new Bird("bird");
        //bird.nome;            // simplify constructor
        Goose goose = new Goose("gooose");
        Person p = new Person("f", "l");
        public void w()
        {
            bird.SayName();
            //bird.nome;
            Console.WriteLine(goose.nome);
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p);
        }

    }



    class Bird(string nome)
    {
        public void SayName()
        {
            Console.Write("my name is " +nome);
        }
    };


    public record Goose(string nome);
    public record Person(string FirstName, string LastName);


}
