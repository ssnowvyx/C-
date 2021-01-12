using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
{
            int a=1,b,r,c,x;
            
        do{
            Console.WriteLine("1.Show multiplication tables from 1-25.");
            Console.WriteLine("2.Display the result of the multiplication table according to the numbers we entered.");
            Console.WriteLine("3.Exit the program");
            Console.WriteLine("select :");
            string input = Console.ReadLine();
            Int32.TryParse(input, out a);
        if(a == 1){
            for(r=1;r<=25;r++)
          {
            for(c=1;c<=12;c++)
            {
                Console.WriteLine("{0} x {1} = {2}",r,c,c*r);
            }
            Console.WriteLine(" ");
          }
        }
        else if (a==2){
          Console.WriteLine("Multiplication table :");
          b = Convert.ToInt32(Console.ReadLine());
         for(c=1;c<=12;c++)
            {
                Console.WriteLine("{0} x {1} = {2}",b,c,c*b);
            }         
            Console.WriteLine(" ");
                      }
    }
        while (a < 3);
            Console.WriteLine(" ");
            Console.WriteLine("end program");
} 
    }
}
