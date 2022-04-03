using ExceptionHomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Building of Rooms
            Room r1 = new Room("SeaScenery", 500, 4, false);
            Room r2 = new Room("WindowToCity", 700, 3, true);
            Room r3 = new Room("VIP", 1000, 1, true);
            Room r4 = new Room("Ordinary", 200, 2, true);
            Room r5 = new Room("ForFamilyy", 400, 5, false);

            //Building Of Hotel
            Hotel hotel = new Hotel("Hills", 4);
            hotel[0] = r1;
            hotel[1] = r2;
            hotel[2] = r3;
            hotel[3] = r4;

            //AddRoom Method
            hotel.AddRoom(r5);


            //ShowInfo Method
            r1.ShowInfo(r1);
            r5.ShowInfo(r5);
            r2.ShowInfo(r2);
            r3.ShowInfo(r3);
            r4.ShowInfo(r4);


           
            //Null  Id of Room
            int? Id1 = null;
            int num1 = Convert.ToInt32(Id1);


            //Id from user inpput 
            Console.WriteLine("Enter the Id of room from keyboard");
            int? Id=int.Parse(Console.ReadLine());

            //Conversion of nullable int type to Int
            int num = Convert.ToInt32(Id);


            //Console.WriteLine(hotel[number - 1].IsAvailable);
           //Console.WriteLine(hotel.Reserve(number));

           
            
            //If you want to check program with null in following part write num1 instead of num
            if (hotel.Reserve(num) == true)
            {
                if (hotel[num-1].IsAvailable == true)
                {
                    hotel[num-1].IsAvailable = false;
                }
                
                else
                {
                    throw new NotAvailableException("Room is already reserved");
                }
                     
            }   
            else { throw new NotFoundException("Room with this id does not exist");}
            

        }
    }
        }
