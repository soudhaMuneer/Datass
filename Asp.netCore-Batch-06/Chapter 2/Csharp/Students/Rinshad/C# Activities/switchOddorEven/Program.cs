using System.Transactions;

namespace myApp
{
    internal class Find
    {
      static void Main(string[] args)   
        {
            Console.WriteLine("Enter A number We will find it and give the result Odd or Even");
            int number= Convert.ToInt32(Console.ReadLine()); 
            
            switch ( number % 2)
            { 

                case 0 :
    
                Console.WriteLine("enter number is even");
                    break;

               case 1 :
                   Console.WriteLine(number +"enter number is odd");
                    break;
              
            }

        }

    }
}