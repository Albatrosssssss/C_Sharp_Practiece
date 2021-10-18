//A constructor is a special method that is used to initialize objects. 
//The advantage of a constructor, is that it is called when an object of a class is created. 
//It can be used to set initial values for fields

//Non parameterized Constructor / Default constructor

//program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car(); //create object for car class
            Console.WriteLine(ford.model);
        }
    }
}


//Car.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test
{
    class Car
    {
        public string model;
        
        public Car() //constructor
        {
            model = "2021"; //set initial value
        }
    }
}
//outpur"2021"



