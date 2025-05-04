using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes
{
    static internal class PropsExample
    {
        static void Create()
        {
            Dog dog = new Dog(2,"john");
        }
    }



    public class Dog
    {
        int Idade { get; set; }
        string nome { get; init; }

        public Dog(int idade, string nome)
        {
            Idade = idade;
            this.nome = nome;
        }

        void Rename(string _name)
        {
            //this.nome = _name;  NOT GONNA WORK
            //only works at constructor
            Idade = 2;
        }


    }



}
