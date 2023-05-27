//using System;

//abstract class Name
//{
//    public void Display()
//    {
//        Console.WriteLine("Non Abstract class");
//    }



//}

//class Abstrct : Name
//{
//    public static void Main()
//    {

//        Abstrct a1 = new Abstrct();
//        a1.Display();
//        Console.ReadLine();
//    }
//}
    

//-----------------------------------------------------------------------------------------------------------------------------------------------------------

//using System;
//namespace AbstractClass
//{

//    abstract class Animal
//    {

//        // abstract method
//        public abstract void makeSound();
//    }

//    // inheriting from abstract class
//    class Dog : Animal
//    {

//        // provide implementation of abstract method
//        public override void makeSound()
//        {

//            Console.WriteLine("Bark Bark");

//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // create an object of Dog class
//            Dog obj = new Dog();
//            obj.makeSound();

//            Console.ReadLine();
//        }
//    }
//}

//------------------------------------------------------------------------------------------------------------------------------------------------------

//using System;
//namespace AbstractClass
//{
//    abstract class Animal
//    {

//        protected string name;
//        // abstract method
//        public abstract string Name
//        {
//            get;
//            set;
//        }
//    }

//    // inheriting from abstract class
//    class Dog : Animal
//    {

//        // provide implementation of abstract method
//        public override string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }

//    }
//    class Program
//    {
//        static void Main()
//        {
//            // create an object of Dog class
//            Dog obj = new Dog();
//            obj.Name = "Tom";
//            Console.WriteLine("Name: " + obj.Name);

//            Console.ReadLine();
//        }
//    }
//    }




//----------------------------------------------------------------------------------------------------------------------------------------------

//Nested Class ---we can define the class within an other class.


//using System;


// public class car
//{
//    public string Brand =  "Mahindra";


//    public class Engine
//    {
//        public void displaycar()
//        {
//            car sportscar = new car();
//           Console.WriteLine("Brand: " +  sportscar.Brand);
//        }
//    }

//}

//class Program
//{
//    public static void Main()
//    {
//        car.Engine MountinCar  = new car.Engine();
//        MountinCar.displaycar();
//        Console.ReadLine();
//    }
//}

//----------------------------Static class-----------------------------------------------------------------------------------------------------------

//using System;
//public static class MyMath
//{
//    public static float PI = 3.14f;
//    public static int cube(int n) { return n * n * n; }
//}
//class TestMyMath
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Value of PI is: " + MyMath.PI);
//        Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));
//    }
//}

