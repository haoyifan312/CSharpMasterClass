using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // member variable
        private string _model = "";
        private string _brand = "";


        //constructor
        public Car(string brand, string model) 
        {
            _brand = brand;
            _model = model;
            Console.WriteLine($"An {_brand} of the model {_model} has been created!");
        }
    }
}
