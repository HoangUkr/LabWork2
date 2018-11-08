using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student: Pham Xuan Hoang");
            Console.WriteLine("Group: IS-63");
            Console.WriteLine("Structural Pattern");
            Traveller traveller = new Traveller();
            Console.WriteLine("Choose type vehicle: "); //вибір виду транспорту
            int key = int.Parse(Console.ReadLine());    
            if(key == 1)    //автомобіль
            {
                Console.WriteLine("Enter price: ");
                double price = double.Parse(Console.ReadLine());    //введення вартість
                Console.WriteLine("Enter time: ");
                int time = int.Parse(Console.ReadLine());           //введення часу
                Car car = new Car(price,time);
                traveller.Travel(car);
            }
            else if (key == 2)  //велосипед
            {
                Console.WriteLine("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter time: ");
                int time = int.Parse(Console.ReadLine());
                Bicycle bicycle = new Bicycle(price, time);
                traveller.Travel(bicycle);
            }
            else   // поїзд
            {
                Console.WriteLine("Enter price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter time: ");
                int time = int.Parse(Console.ReadLine());
                Train train = new Train(price, time);
                traveller.Travel(train);
            }
            Console.ReadKey();
        }
    }
}
