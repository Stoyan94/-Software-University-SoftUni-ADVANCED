using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Classes_Fields_PROP
{
    internal class Car
    {
        //fields
        private int mileage;

        //fields-използваме ги за валидации, подаване на данни отвън и също така външният свят
        // да не може да вижда полетата , само ни е с цел защита на private данни и избягване на бъгове 
        public int Mileage 
        {
            get { return mileage; }
            set 
            {
                //ключовата дума "value" е специфична само за "set" когато извикаве извън "class Car"
                // самото property с име "Milage" - car.Milage = 5, value идва в prop. след самото "="
                // и получава самото value което му е подадено отвън
                Console.WriteLine($"Setting value : {value}");
                if (value<0)
                {
                    Console.WriteLine($"Wrong value!!!");
                }
                else
                {
                    mileage = value;
                }
               
            }
        }
    }
}
