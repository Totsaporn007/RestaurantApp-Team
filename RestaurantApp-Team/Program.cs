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
        static List<Restaurant> restaurantlist = new List<Restaurant>();
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
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }


        static void ShowRestaurant()
        {


        }

    }

}
