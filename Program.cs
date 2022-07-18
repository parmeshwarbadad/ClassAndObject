using System;

namespace ClassAndObject
{
    class Car
    {
        int modelname;
        string name;
        string colour;
        int price;
        static void Main(string[] args)
        {
            Car c = new Car();
                c.modelname=11;
            c.name = "scoda";
            c.colour = "black";
            c.price = 12000;
            Console.WriteLine(" Details of the car is: "
                       + "\n model number is: " +c.modelname+" \n Name of the car is: " 
                       +c.name+ "\n Colour of care is: "
                       + c.colour+"\n Price of car is: "+c.price);
        }
    }
}
