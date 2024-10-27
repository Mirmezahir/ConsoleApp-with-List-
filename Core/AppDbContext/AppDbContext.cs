using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Models;

namespace Core.AppDbContext
{
    public static class AppDbContext

    {
        static List<Hotel> hotels = new List<Hotel>();
       static List<Room> rooms = new List<Room>();
        public static void Allroom()
        {
            Console.WriteLine("------------------------------------------------");
            string Aktif;
            for (int i = 0; i < rooms.Count; i++)
            {
               if (rooms[i].IsAvialable)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(rooms[i].ID + "." + rooms[i].Name + "-" + rooms[i].Price + "AZN " +" Musteri tutumu :" + rooms[i].PersonCapasity +" Reserv edilmeyib");
                    Console.ForegroundColor= ConsoleColor.White;
                }
               else
                {


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(rooms[i].ID + "." + rooms[i].Name + "-" + rooms[i].Price + "AZN " + " Musteri tutumu :" + rooms[i].PersonCapasity + "Reserv edilib");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                
            }
            Console.WriteLine("------------------------------------------------");

        }
        public static void AddRoom(Room room )
        { 
            rooms.Add( room );
        }
        public static void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }
       public static List<Room> FindAllRoom(string name)
        {
            return rooms.FindAll(x=> x.Name==name);
        }
       public static Room FindRoom(int id)
        {
            return rooms.Find(x=> x.ID==id);

        }
        public static bool HotelIdChecker(int id)
        {
            bool idcheck=false;
            for (int i = 0; i < hotels.Count; i++)
            {
                if (hotels[i].ID == id)
                {
                    idcheck = true;
                }
                else
                {
                    idcheck = false;
                    Console.WriteLine("Duzgun id daxil edin");
                    
                    break;
                }
            }
            return idcheck; 
        }
       public static bool MakeReservation(User user ,int id,int person)
        {
            bool IsReserved = false;
            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms[i].IsAvialable == true) 
                { 
                    if (user.Balance >= rooms[i].Price && rooms[i].ID==id)
                    {                   
                        
                            if (rooms[i].PersonCapasity >= person)
                            {
                                user.Balance = user.Balance-rooms[i].Price;
                                rooms[i].IsAvialable = false;
                                IsReserved = true;
                                break;

                            }
                            else
                            {
                                IsReserved = false;
                                Console.WriteLine("Otaq tutumu desteklemir!");
                                break;
                            }
                        
                        
                    }
                    else
                    {
                        IsReserved = false;
                        Console.WriteLine("Kifayet qeder balansiniz yoxdur ! ");
                    }
                }


            }
            return IsReserved;
           
        }   
        public static void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
     
       public static void ShowHotels()
        {
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.ID+"."+hotel.Name);
            }
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        }
      
    }
}
