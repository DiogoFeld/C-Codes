using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.ComplexType
{
    internal class StructExample
    {
        void Show()
        {
            //semantica de valor
            Pessoa pessoa = new Pessoa("miio");
            Pessoa pessoa2 = pessoa;
            pessoa2.Nome = "novo";

            //semantica de referencia
            PessoaC pessoaaa = new PessoaC("miio");
            PessoaC pessoa2aa = pessoaaa;
            pessoa2.Nome = "novo";
            //ambas mudam
        }
    }

    public struct Pessoa
    {
        public string Nome { get; set; }
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
    }

    public class PessoaC
    {
        public PessoaC(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
    }



    public struct Time
    {
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                throw new ArgumentOutOfRangeException(
                    "Hour is out of range of 0-23");
            }
            if (minute < 0 || minute > 59)
            {
                throw new ArgumentOutOfRangeException(
                    "Minute is out of range of 0-59");
            }
            Hour = hour;
            Minute = minute;
        }

        public override string ToString() =>
            $"{Hour.ToString("00")}:{Minute.ToString("00")}";

        // == and != operator overloads
        public static bool operator ==(Time left, Time right) =>
            left.Hour == right.Hour && left.Minute == right.Minute;

        public static bool operator !=(Time left, Time right) =>
            !(left == right);

        public override bool Equals(object obj) =>
            obj is Time other && this == other;

        public override int GetHashCode() =>
            HashCode.Combine(Hour, Minute);

        // + operator overload
        public static Time operator +(Time t1, Time t2)
        {
            int totalMinutes = t1.Minute + t2.Minute;
            int extraHours = totalMinutes / 60;
            int finalMinutes = totalMinutes % 60;

            int totalHours = (t1.Hour + t2.Hour + extraHours) % 24;

            return new Time(totalHours, finalMinutes);


            //your code goes here      
        }
    }


    public class FullName
    {
        public string First { get; init; }
        public string Last { get; init; }

        public override string ToString() => $"{First} {Last}";

        public override bool Equals(object? obj)
        {
            return obj is FullName fn &&
                First == fn.First && Last == fn.Last;
        }

    }



}
