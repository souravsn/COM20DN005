using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //    class Program
    //    {
    ////        static void Main(string[] args)
    //        {
    //            //Console.WriteLine("Hello World!");
    //            //Console.WriteLine("Hello Sourav");

    //            //int num =3 ;
    //            //Console.WriteLine("the number is: " + num);
    //            //Console.Read();

    //            string sysname = "Sourav";
    //            string message = "My name is " + sysname;

    //            string capsMessage = message.ToUpper();
    //            string lowerCaseMessage = message.ToLower();

    //            Console.WriteLine(sysname);
    //            Console.WriteLine("My name is : " +sysname);
    //            Console.WriteLine(capsMessage);
    //            Console.WriteLine(lowerCaseMessage);


    //            Console.Read();




    //        }
    //    }





     class WriteLine
    {
        //public static void Main(string[] args)
        //{
        //    Console.Write("enter a string");
        //    string readinput = Console.ReadLine();
        //    Console.WriteLine("you have entered : {0}", readinput);

        //    Console.Write("enter a string");
        //    int asciiValue = Console.Read();
        //    Console.WriteLine("ascii Value is : {0}", +asciiValue);
        //    Console.ReadKey();
        //}


        public static void Main(string [] args)
        {
            Console.Write("Enter the value for x");
            int x = Console.Read();

            Console.Write("Enter the value for y");
            int y = Console.Read();

            if ((result(x,y)) == true)
            //    Console.WriteLine(+ x +"is smaller");
            //else
            //    Console.WriteLine(+ y + "is smaller");

            Console.Read();

            static bool result(int x, int y)
            {
                bool result = true;
                if (x < y)
                {
                    result = true;
                    return result;
                }
            }
           
        }




















        //public class Program                //DO NOT Change class 'Program' name
        //{
        //public static void Main(string[] args)        //DO NOT Change 'Main' method Signature
        //{
        //    //Implement your code here
        //    Console.WriteLine("Enter a Number : ");
        //    double number = Console.Read();

        //    Console.WriteLine(FindSquare(number));
        //    Console.WriteLine(FindCube(number));

        //    Console.Read();

        //}

        ////Implement methods here. Keep the method 'public' and 'static'
        //public static double FindSquare(double number)
        //{
        //    double num = Math.Pow(number,2);
        //    //Math.Sqrt("Square of " + number + "is", )
        //    return num;
        //}

        //public static double FindCube(double number)
        //{
        //    double num = Math.Pow(number,3);
        //    return num;

        //}



        //}
    }
}



































































































//namespace EnumEg
//{
//    enum cities
//    {
//        Chennai = 1, Hyderabad, Bangalore, Mumbai, Pune, Delhi
//    };
//    class Emp
//    {
//        public int eid { get; set; }//Auto Implemented Properties
//        public string ename { get; set; }
//        public cities location { get; set; }

//        public Emp()
//        {
//            eid = 1000;
//            ename = "kavin";
//            location = cities.Bangalore;
//        }
//    }


//    //from Jamuna Balamurugan to everyone:    12:48 PM
//    class Program
//    {
//        //static void Main(string[] args)
//        //{
//        //    Emp e = new Emp();
//        //    try
//        //    {
//        //    Console.WriteLine("Enter the Empid");
//        //    e.eid = Convert.ToInt32(Console.ReadLine());
//        //    Console.WriteLine("Enter the name");
//        //    e.ename = Console.ReadLine();
//        //    Console.WriteLine("Enter the location(Chennai,Hyderabad, Bangalore, Mumbai,Pune,Delhi");
//        //    string w = Console.ReadLine();
//        //    e.location = (cities)Enum.Parse(typeof(cities), w);
//        //    Console.WriteLine("The employee details are :" + e.eid + " " + e.ename + " " + e.location);
//        //    Console.ReadKey();
//        //        }
//        //    catch (invalidenumargumentexception)
//        //    {
//        //        Console.WriteLine("InvalidEnumArgumentException.....Pls enter a valid City");
//        //    }
//        //    catch (ArgumentException)
//        //    {
//        //        Console.WriteLine("ArgumentException....Pls enter a valid City");
//        //    }
//        //    catch (FormatException e1)
//        //    {
//        //        Console.WriteLine("Kindly enter Empid in the correct format(int)");
//        //    }
//        //    catch (Exception e1)
//        //    {
//        //        Console.WriteLine(e1.Source);
//        //        Console.WriteLine(e1.Message);
//        //        Console.WriteLine("Sorry....Incorrect data has been entered for Employee!!!");
//        //    }

//        //    finally
//        //    {
//        //        Console.WriteLine("Sorry");
//        //    }
//        //}

//        //from Jamuna Balamurugan to everyone:    1:33 PM
//        static void Main(string[] args)
//        {
//            Emp e = new Emp();
//            try
//            {
//                Console.WriteLine("Enter the Empid");
//                e.eid = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the name");
//                e.ename = Console.ReadLine();
//                Console.WriteLine("Enter the location(Chennai,Hyderabad, Bangalore, Mumbai,Pune,Delhi");
//                string w = Console.ReadLine();
//                e.location = (cities)Enum.Parse(typeof(cities), w);
//                Console.WriteLine("The employee details are :" + e.eid + " " + e.ename + " " + e.location);
//                Console.ReadKey();
//            }

//            //from Jamuna Balamurugan to everyone: 1:33 PM
//            catch (InvalidEnumArgumentException)
//            {
//                Console.WriteLine("InvalidEnumArgumentException.....Pls enter a valid City");
//            }
//            catch (ArgumentException)
//            {
//                Console.WriteLine("ArgumentException....Pls enter a valid City");
//            }
//            catch (FormatException e1)
//            {
//                Console.WriteLine("Kindly enter Empid in the correct format(int)");
//            }
//            catch (Exception e1)
//            {
//                Console.WriteLine(e1.Source);
//                Console.WriteLine(e1.Message);
//                Console.WriteLine("Sorry....Incorrect data has been entered for Employee!!!");
//            }
//            finally
//            {
//                Console.WriteLine("Inside Finally Block...Its called whether an exception occurs or not");
//            }
//            Console.WriteLine("After Finally Block");
//            Console.Read();
//        }
//    }

//}