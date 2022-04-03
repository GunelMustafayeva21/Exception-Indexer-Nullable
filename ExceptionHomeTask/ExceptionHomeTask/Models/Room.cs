using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomeTask.Models
{
    public class Room
    {

        private static int ID = 0;
        private int myId = 0;
        public int MyId
        {
            get { return myId; }
        }


        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }

        private bool isAvailable;
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }

        public Room(string Name, int Price, int PersonCapacity, bool IsAvailable)
        {

            ID++;
            this.myId = ID;
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
            isAvailable = IsAvailable;
        }
        public override string ToString()
        {
            return "Room's Id --> " + myId + "  Name --> " + Name + "  Price --> " + Price + "  Person Capacity --> " + PersonCapacity+"  Room is available --> "+ isAvailable;
        }
       public void ShowInfo(object r)
        {
            Console.WriteLine(r);
        }
        
    }
}
