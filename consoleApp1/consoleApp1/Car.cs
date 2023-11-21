using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace consoleApp1
{
    internal class Car
    {
        //member variables
        private string _name; // private field used for storing data 
        private int _hp;
        private string _color;

        //auto-implement property
        public int MaxSpeed { get; set; }

        //public property || getter and setter 
        public string Name
        {
            get { return _name; } //get
            set
            {
                if (value == "")
                {
                    _name = "DefaultName";
                }
                else
                {
                    _name = value;
                }
                //set  
            }
        }

        //default constructor
        public Car() 
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }
      /*
        //setters - you can change a variable but not directly
        public void setName(string name)
        {
            if(name == "")
            {
                this._name = "DefaultName";
            }
            else
            {
                this._name = name;
            }
           
        }
     
        //getter - you can get data from a private variable
        public string getName()
        {
            return _name;
        }

        //getter
        public int getHp() 
        {
            return _hp; 
         }
      */
     
        //partial specification constructor
        public Car(string name, int hp = 0) 
        {
            this._hp = hp;
            this._name = name;
            _color = "red";
            Console.WriteLine($"{name} was created.");
        }

        //full specification constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            this._hp = hp;
            this._name = name;
            this._color = color;
            Console.WriteLine($"{name} was created.");
        }

        //member method
        public void Drive()
        {
            Console.WriteLine($"{_name} is driving");
        }

        //member method
        public void Stop()
        {
            Console.WriteLine($"{_name} stopped.");
        }

        //member method
        public void Details()
        {
            Console.WriteLine($"The car {_name} has {_hp} hp and color {_color}.");
        }
    }
}
