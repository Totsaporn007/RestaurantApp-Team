using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(string name, string type, double rating) { Name = name;Type = type;Rating = rating; }

        
{
new Restaurant { Name = &quot; KFC&quot;, Type = &quot; Fast Food&quot;, Rating = 4.2 },
new Restaurant { Name = &quot; MK&quot;, Type = &quot; Suki&quot;, Rating = 4.7 },
new Restaurant { Name = &quot; Fuji&quot;, Type = &quot; Japanese&quot;, Rating = 4.8 }
    };
}

    internal class Program
    {
        static List<Restaurant> RestaurantsList = new List<Restaurant>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant() {
         
            Console.WriteLine("กรอกข้อมูลร้าน : ");
            string name = Console.ReadLine();

            Console.WriteLine("กรอกประเถทร้านอาหาร เช่น (hot pot) :");
            string type = Console.ReadLine();

            Console.WriteLine("กรอก");

        }

            // คน B รับผิดชอบ
            static void ShowGoodRating()
        {

            var goodRatingRestaurants = RestaurantsList.Where(r => r.Rating >= 4.5);

            Console.WriteLine("--- ร้านที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป ---");
            foreach (var r in goodRatingRestaurants)
            {
                Console.WriteLine($"ชื่อ: {r.Name} | ประเภท: {r.Type} | คะแนน: {r.Rating}");
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }


        // คน D รับผิดชอบ
        static void ShowRestaurant()
        { 
            
        }

    }

}
