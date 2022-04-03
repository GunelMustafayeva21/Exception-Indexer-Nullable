using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeTask.Models
{
    public class Hotel
    {

        public string Name { get; set; }
        private Room[] Rooms;

        public Hotel(string Name, int size)
        {
            this.Name = Name;
            Rooms = new Room[size];

        }
        public Room this[int index]
        {
            get { return Rooms[index]; }
            set { Rooms[index] = value; }
        }
        public void AddRoom(Room r)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = r;
        }
        public bool Reserve(int ?number)
        {
            if (number != null)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (number == i) { return true; }
                }
                return false;
            }
            else
            {
                return false;
            }

        }


    }

        
    }
