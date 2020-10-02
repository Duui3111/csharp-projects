using System;

namespace RandomGen
{
    public class Program
    { 
       public static void Main(string[] args)
        {
          Program pr = new Program();  
          
          for(int i = 0; i <= 10; i++) 
            Console.WriteLine(pr.RandomNumber(5, 8)); 

          Console.ReadKey();
        }
        private readonly Random _random = new Random();  
       
        public int RandomNumber(int min, int max)  
        {  
            return _random.Next(min, max);  
        }  
    }
