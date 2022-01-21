using System;

namespace class_practice2S
{

    class car
    {
        public int size;
        public int numberOfDoors;
        public int MaxSpeed;

        public string typeOfCar;

        public string color;
    };

    public enum Month{
        Unknown, Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }
    class Program
    {
        public struct Date{

            public int Year;

            public int Day;

           public Month Month;
        }
        //part of day three notes
        public class Eyeglass
        {
            bool shouldBeWorn;
            public static void putOn(Eyeglass eyeglass)
            {
                eyeglass.shouldBeWorn = true;
            }

        }

        //still part of day three notes
        public class Custumer
        {
            public int customerCount = 0;//this only happens once
            private string name;

            private int id;

            public Custumer(string name)
            {
                this.name = name;
                this.customerCount++;
                this.id = customerCount;
            }
        }
        static void Main(string[] args)
        {
           car sarasCar = new car();
           car MaxsCar;
           MaxsCar = new car();
           car MaxsCopyCar = MaxsCar;
           //Two tags, 3 references, 2 objects
           //Press f5 for debugger
           //class key word lets us reference our class
           //'new' keyword lets us use an instance of the class
           //class is the cookie cutter, object is the cookie
           //f10 to execute the next line of code in the debuger.
           MaxsCar.numberOfDoors = 4;
           sarasCar.numberOfDoors = 2;
           MaxsCopyCar.MaxSpeed = 550;
           //specs of my fiancee's car
           car goobinCar = new car();
           goobinCar.color = "red";
           goobinCar.numberOfDoors = 4;
           goobinCar.size = 8;
           goobinCar.typeOfCar = "mini cooper";

           Console.WriteLine($" the color of car is: {goobinCar.color}\n the size of the car is: {goobinCar.size}ft\n the number of doors is: {goobinCar.numberOfDoors}\n the brand of car is: {goobinCar.typeOfCar}\n");
           //Day 2 notes start here
           //for struct you don't need the new keyword because the Dat mlkJrDay creates a space big enough for day month year on its own
           // classes requre the new keyword.
           Date[] todoItems = new Date[10];
           Date mlkJrDay;
           mlkJrDay.Year = 2022;
           mlkJrDay.Month = Month.Jan;
           mlkJrDay.Day = 17;
           

           int answer = 100;
           int numberOfGuesses = 0;

           Console.WriteLine("please guess a number.");
           string userInput = Console.ReadLine();
           int userInputInt;
           bool succsess = int.TryParse(userInput, out userInputInt);
           numberOfGuesses++;
           if (userInputInt == answer)
           {
               Console.WriteLine("you did it!");
           }

           //Day 3 class practice
           var mustafaGlasses = new Eyeglass();
           // mustafaGlasses.putOn();
           // Eyeglass.putOn();
           var joey = new Custumer("joey");
           var phil = new Custumer("phil");

           

        }
    }
}