using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Room
    {
        private static int _id;
        public int ID { get;  }
        public string Name { get; set; }
        public int Price { get; set; }

        public string FulInfo;

        public Room(string name, int price, int personCapasity)
        {
            Name = name;
            Price = price;
            PersonCapasity = personCapasity;
            ++_id;
            ID = _id;   
            FulInfo=name+" "+price.ToString()+" "+PersonCapasity.ToString();
        }

        public int PersonCapasity { get; set; }
        public bool IsAvialable { get; set; }=true;
        public override string ToString()
        {
            return FulInfo;
        }


    }
}
