using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.ComplexType
{
    internal class RecordStruct
    {
        GpsCoordinates gpsCoordinates = new GpsCoordinates(1, 2);

    }



    public record struct GpsCoordinates(double Latitude,double Longitude);
    //public record  GpsCoordinates(double Latitude,double Longitude);



    //Define a GpsCoordinates positional record representing a point on Earth.It should have two double properties: Latitude and Longitude.
    //This type should be immutable.
    //Este tema é abordado em
    public class Bird
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Pais { get; set; }
    }
}
