using System;

namespace ExceptionHandling4
{
    public class Pet
    {
        public string Name { get; set; }
        public string Breed {  get; set; }
        public int Age {  get; set; }
        
    }
    
    public class AgeException : Exception
    { 
        public AgeException() { }
        public AgeException(int message) : base(string.Format( "Dogs below age "+message+" not found")) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //list pet's whose age is less than 4
            int petAge = 4;
            List<Pet> petList = new List<Pet>();
            try
            {
                petList.Add(new Pet { Name = "Buddy", Breed = "German Shepherd", Age = 4 });
                petList.Add(new Pet { Name = "Milo", Breed = "Bulldog", Age = 2 });
                petList.Add(new Pet { Name = "Rocky", Breed = "Golden Retriever", Age = 2 });
                petList.Add(new Pet { Name = "Oliver", Breed = "French Bulldog", Age = 5 });
                petList.Add(new Pet { Name = "Charlie", Breed = "Serbian Husky", Age = 5 });

                foreach (var pets in petList)
                {
                    if ( pets.Age <= petAge)
                    {
                        Console.WriteLine("Name:" + pets.Name);
                        Console.WriteLine("Breed:" + pets.Breed);
                        Console.WriteLine("Age:" + pets.Age);
                        Console.WriteLine("---------------------------");
                    }
                    else
                    {
                        throw new AgeException(petAge);
                        
                    }
                }

            }
            catch (Exception AgeException) 
            {
                Console.WriteLine(AgeException.Message);
            }

        }
    }
}
