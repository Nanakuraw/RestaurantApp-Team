using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
           {
             new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
             new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
             new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
             
             new Restaurant(4, "Sushi Hiro", "Japanese", 4.2),
             new Restaurant(5, "The Pizza Company", "Italian", 4.8)
           };
            foreach (var item in restaurants)
           {
               Console.WriteLine($"{item.Name} Type:{item.Type} -- {item.Rate}");
              
           }
            Console.WriteLine($"จำนวนร้านทั้งหมด:{restaurants.Count}");

            double average = restaurants.Average(item => item.Rate);

            Console.WriteLine($"avg :{average}");

            Console.WriteLine("Mos");
            Console.WriteLine("TodGay");
            Console.WriteLine("Tae");
        }

    
         
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public  double Rate { get; set; }

        public Restaurant(int id, string name, string type, double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;
            this.Type = type;
        }
        
    }

   
   
}
