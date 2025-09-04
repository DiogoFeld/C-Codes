using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.Evolution
{
    internal class cSharp11RequiredEx
    {

        //Car c = new Car();
        //reclama da falta de Plcaca
        //Car c = new Car{ Placa = "done"};
        //ou com setsRequiredMenbers
        Car c = new Car("donee");


    }


    class Car
    {
        [SetsRequiredMembers]
        public Car(string placa)
        {
            Placa = placa;
        }



        //public string Placa { get; set; }
        //mas é NECESSARIO ter placa
        public required string Placa { get; init; }
    }
}
