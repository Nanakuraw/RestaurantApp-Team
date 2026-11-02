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
            Console.WriteLine("เพิ่มชื่อร้าน : ");
            string name = Console.ReadLine();

            Console.WriteLine("ระบุประเภทร้าน : ");
            string type = Console.ReadLine();

            Console.WriteLine("เพิ่มคะแนนของร้าน : ");
            string input = Console.ReadLine();
            double rate = double.Parse(input);

            int nextId = restaurants.Count + 1;

            Restaurant newRestaurant = new Restaurant(nextId, name, type, rate);
            restaurants.Add(newRestaurant);

            Console.WriteLine("\n--- ร้านค้าที่มีคะแนน 4.5 ขึ้นไป ---");
            var topRestaurants = restaurants.Where(r => r.Rate >= 4.5);
            foreach (var shop in topRestaurants)
            {
                Console.WriteLine($"[{shop.Id}] {shop.Name} ({shop.Type}) - คะแนน: {shop.Rate}");
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
