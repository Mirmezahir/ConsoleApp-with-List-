using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Hotel
    {
        private static int _id;
        public int ID { get;  }
        public string Name { get; set; }
        public Hotel(string name )
        {
            Name = name;
            ++_id;
            ID = _id;
        }

    }
}
