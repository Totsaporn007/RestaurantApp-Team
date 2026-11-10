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
        public Restaurant(string name,string type,double rating)
        {
            Name = name;
            Type = type;
            Rating = rating;

        }
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
                Console.WriteLine("4. Show Restaurant");
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
                    case "4":
                        ShowRestaurant();
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
        static void AddRestaurant()
        {
  
            Console.Write("กรอกชื่อร้าน : ");
            string name = Console.ReadLine();

            Console.Write("กรอกประเภท : ");
            string type = Console.ReadLine();

            Console.Write("กรอกเรทติ้ง : ");
            double rating = Convert.ToDouble(Console.ReadLine());

            restaurantlist.Add(new Restaurant(name, type,rating));
            Console.WriteLine("เพิ่มเรียบร้อย");
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
            double total = 0;
            double highest = double.MinValue;
            foreach (Restaurant r in restaurants)
            {
                total += r.Rating;
                if (r.Rating > highest)
{
                    highest = r.Rating;
                }
            }
            
            double lowest = double.MaxValue;
            foreach (Restaurant r in restaurants)
            {
                total += r.Rating;
                if (r.Rating < lowest)
                {
                    lowest = r.Rating;
                }
            }
            double average = total / restaurants.Count;
            Console.WriteLine(" จำนวนร้าน:"  +restaurants.Count);
            Console.WriteLine( "คะแนนเฉลี่ย:"  +average.ToString( "F2" ));
            Console.WriteLine( "คะแนนสูงสุด:"  +highest);
            Console.WriteLine("คะแนนต่ำสุด:" + lowest);
        }
        // คน D รับผิดชอบ
        static void ShowRestaurant()
        {
            Console.WriteLine("=== รายชื่อร้านอาหาร ===");
            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine(
                r.Name + " | " +
                r.Type + " | " +
                r.Rating
                );
            }
           
             
        }
       }

    }





