using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.OOP
{
    abstract class InterfaceImpFather
    {
        string nome;

        protected InterfaceImpFather(string nome)
        {
            this.nome = nome;
        }
    }

    //uma classe pode herdar apenas 1 classe abstrata ou concreta, mas pode implementar diversas interfaces
    internal class InterfaceImp : InterfaceImpFather,doStuf, doMoreStuf
    {
        public InterfaceImp(string nome) : base(nome)
        {
        }

        public void doAnotherOfThis()
        {
            throw new NotImplementedException();
        }

        public void doThis()
        {
            throw new NotImplementedException();
        }
    }

    interface doStuf
    {
        void doThis();
    }

    interface doMoreStuf
    {

        void doAnotherOfThis();
    }

}