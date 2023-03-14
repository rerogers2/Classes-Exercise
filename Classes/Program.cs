using Microsoft.VisualBasic;
using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            newCar.Make = "Honda";
            newCar.Model = "CRV";
            newCar.Year = 2019;

            newCar.Convo();
        }
    }
}
