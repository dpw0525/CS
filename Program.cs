//use the whole computer
using System;

//name of file 
namespace NumbericTypes
{

//what program?
    class rectangle
    {
     //visual to others, 
       public static void Main(string[] args)
        {
            // doubles are numbers, and lists of all tasks for it to find, string will be complete
            double length;
            double width;
            double area;
            string input;

            //Now, tell console to do that task
            Console.WriteLine("length: ");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine ("width: ");
            input = Console.ReadLine();
            width = double.Parse(input); 
    
            area = (length * width);
            Console.WriteLine ("area: " + area);
            input = Console.ReadLine();
        }

    }   

}