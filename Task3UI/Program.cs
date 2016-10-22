using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.AutoInfo();

            SportCar sportCar = new SportCar();
            sportCar.SportCarInfo();


            Console.ReadKey();    
        }
    }
}
