using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure_Pattern
{
    class Bicycle : ITransport
    {
        private double price;   // вартість проїзду
        private int time;       // час проїзду
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_price"></param>
        /// <param name="_time"></param>
        public Bicycle(double _price, int _time)
        {
            price = _price;
            time = _time;
        }
    
        internal Traveller Traveller
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        /// <summary>
        /// Виведення вартість
        /// </summary>
        public void Get_Price()
        {
            Console.WriteLine("Cost travel : {0} grn", price);
        }
        /// <summary>
        /// Виведення час
        /// </summary>
        public void Get_Time()
        {
            Console.WriteLine("Time travel : {0} hours", time);
        }
    }
}
