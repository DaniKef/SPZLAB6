using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace SPZLAB6.Classes
{
    [XmlRoot("Hotel")]
    public class Hotel
    {
        [XmlElement("RoomList")]
        public List<Room> RoomList { get; set; } // Номера в отеле
        public Hotel()
        {
            RoomList = new List<Room>()
            {
                new Room(1, 300, true),
                new Room(1, 320, true),
                new Room(1, 320, true),
                new Room(1, 340, true),
                new Room(1, 350, true),
                new Room(2, 700, true),
                new Room(2, 750, true),
                new Room(2, 760, true),
                new Room(2, 880, true),
                new Room(3, 1200, true),
                new Room(3, 3400, true)
            };
        }
    }
}
