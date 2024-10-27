using System;
using System.Runtime.Intrinsics.X86;
using Core.AppDbContext;
using Core.Helpers;
using Core.Models;

namespace ConsoleApp_with_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            bool altmenyu=false;
            bool anamenyu = false;  
            bool userlogin = false;
            bool deyisen = false;
            User user2 = null;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                     WELCOME TO MR.HOTELS          ");
                Console.WriteLine("              PLEASE CREATE ACCOUNT FOR BOOKING          ");
                
                

                    Console.WriteLine("                  [ USER LOGIN ]                       ");
                Console.ForegroundColor= ConsoleColor.White;
                    Console.Write("Fullname : ");
                    string name = Console.ReadLine();



                    Console.WriteLine("Sifre teyin edin !\n-Sifre en az 8 simvol ibaret olmalidir\n-En az bir reqem olmalidir\n-En az bir boyuk" +
                        "herf olmalidir\n-En az bir kicik herf olmalidir\n-En az bir reqem olmalidir!!!");
                    Console.Write("Password : ");
                    User user1 = null;
                    Password_check password_ = new Password_check();
                    bool sifrecheck;
                    do
                    {
                        string password = Console.ReadLine();

                        user1 = new User(name.Trim(), password.Trim());

                        sifrecheck = password_.PasswordCheck(password);

                    } while (!sifrecheck);
                Console.WriteLine("Balansinizi teyin edin");
                int balance;
                do
                {
                    deyisen=int.TryParse(Console.ReadLine(), out balance);
                    if (deyisen == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Reqem daxil edin !");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (!deyisen);
                 User user = user1;
                user.Balance = balance; 
                user2 = user;   
                userlogin = true;   

                break;




                
                
            } while (!userlogin);
            Console.Clear();
            do
            {
                Console.WriteLine($"                                  USER :{user2.Name} {user2.Balance}AZN  ");
                Console.WriteLine("1.Hotel yarat\n2.Show All Hotels\n3.Select Hotel\n0.Exit");
                int anamenyugiris = 0;
                do
                {
                    deyisen = int.TryParse(Console.ReadLine(), out anamenyugiris);
                    if (deyisen == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Reqem daxil edin !");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (!deyisen);
                switch (anamenyugiris)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Otel adi daxil edin : ");
                        string otelname = Console.ReadLine();
                        Hotel hotel = new Hotel(otelname);
                        AppDbContext.AddHotel(hotel);
                        Console.WriteLine("Otel yaradildi");
                        break;
                    case 2:

                        AppDbContext.ShowHotels();
                        break;
                    case 3:
                        Console.Clear();
                        AppDbContext.ShowHotels();
                        Console.Write("Otel secin (ID ILE !): ");
                        int hotelid;
                      
                        do
                        {
                            
                            
                                deyisen = int.TryParse(Console.ReadLine(), out hotelid);
                                if (deyisen == false)
                                {
                                 Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Reqem daxil edin !");
                                   Console.ForegroundColor= ConsoleColor.White;
                                }

                          
                            AppDbContext.HotelIdChecker(hotelid);

                        } while (!AppDbContext.HotelIdChecker(hotelid));


                        Console.Clear();
                        Console.WriteLine($"                              Hotel     ");
                        
                        int altmenyugiris;
                        do
                        {
                            Console.WriteLine($"                                  USER :{user2.Name} {user2.Balance}AZN  ");
                            Console.WriteLine("1.Otaq yarat\n2.Otaqlara bax\n3.Otaq Rezerv Et\n4.evvelki menyuya qayit\n5.Console Clear");
                            
                            deyisen = int.TryParse(Console.ReadLine(), out altmenyugiris);
                            switch (altmenyugiris)
                            {
                                case 1:
                                    Console.Write("Otaq adi daxil edin : ");
                                    string roomname = Console.ReadLine();

                                    int roomprice;
                                    Console.Write("Otaq qiymetini daxil edin : ");
                                    do
                                    {

                                        deyisen = int.TryParse(Console.ReadLine(), out roomprice);
                                       if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Reqem daxil edin !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    } while (!deyisen);
                                    Console.Write("Otaq tutumunu(nece nefer yerlesdiyin) daxil edin : ");
                                    int roomcapacity;

                                    do
                                    {

                                        deyisen = int.TryParse(Console.ReadLine(), out roomcapacity);
                                        if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Reqem daxil edin !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                    } while (!deyisen);
                                    Room room = new Room(roomname, roomprice, roomcapacity);
                                    AppDbContext.AddRoom(room);
                                    Console.WriteLine("Otaq yaradildi");
                                    break ;
                                case 2:
                                    AppDbContext.Allroom();
                                    break;
                                case 3:
                                    AppDbContext.Allroom();
                                    Console.Write("Otaq id-ni daxil edin : ");
                                    int roomnamereserve;
                                    do
                                    {

                                        deyisen = int.TryParse(Console.ReadLine(), out roomnamereserve);
                                        if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Reqem daxil edin !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    } while (!deyisen);
                                    Console.WriteLine("Musteri sayini daxil edin : ");
                                    int roomcapacity1;

                                    do
                                    {

                                        deyisen = int.TryParse(Console.ReadLine(), out roomcapacity1);
                                        if (deyisen == false)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Reqem daxil edin !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    } while (!deyisen);

                                    AppDbContext.MakeReservation(user2,roomnamereserve,roomcapacity1);
             
                                    break;
                                    case 4:
                                    Console.Clear();
                                    altmenyu = true;
                                    break;
                                    case 5:
                                    Console.Clear();
                                    break;

                                        



                            }


                        } while (!altmenyu);


                        break;
                

                    case 0:
                      anamenyu=true;
                        
                        break ;
                      




                }
            }while (!anamenyu);

            
        }
    }
}
