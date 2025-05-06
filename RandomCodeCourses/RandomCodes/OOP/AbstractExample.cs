using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.OOP
{
    internal class AbstractExample
    {


    }


    public abstract class Transporte
    {
        public  string nome;
        public  int maxV;

        public abstract void Barulho();
        public virtual  string Velocidade()
        {
            return $"max v = {this.maxV}";
        }

        public string DizerNome() => "sou um transporte";
        protected Transporte(string nome,int _maxV)
        {
            this.nome = nome;
            this.maxV = _maxV;
        }
    }


    public class Carro : Transporte
    {
        public Carro(string nome, int _maxV) : base(nome, _maxV)
        {
        }

        public override string Velocidade()
        {
            return $"esse carro vai a {this.maxV}";
        }

        public override void Barulho()
        {
            Console.WriteLine("Vruumm");
        }
    }





    /*Classes estaticas podem:
     * criar construturos
     * terem métodos com "corpo"
     * terem atributos proprios
     * 
    Não podem
       ser instanciadas
    serem static
    Elas podem ser herdadas e seus métodos, se tiverem virtual podem ser sobrescritos
    */


}
