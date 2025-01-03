// See https://aka.ms/new-console-template for more information
namespace tp {
    class programm 
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            while (k<10)
            {
                Console.WriteLine(k+1);
                k++;
            }
            do
            {
                Console.WriteLine(k + 5);
                k++;
            } while (k < 10);
            



            Console.WriteLine("Select 1.Even / 2.Odd");
            
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a % 2 )
            {
                case 0:
                        Console.WriteLine("even");
                    
                    break;
                default:
                    Console.WriteLine("odd");
                        break;


            }
        }
    }
    }
