using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB6.Classes
{
    public class Room
    {
        public int NumberOfBerths { get; set; } // Количество спальных мест
        public int Price { get; set; } // Цена
        public bool IsFree { get; set; } // Занят\Свободен
        private static int NumberAllRooms = 0; // Количество всех комнат
        public int NumberOfRoom { get; set; } // Номер комнаты
        public List<string> MonthList;  // занятые месяца
        public Room(int numberOfBerths, int price, bool isFree) // Конструктор
        {
            MonthList = new List<string>();
            NumberOfBerths = numberOfBerths;
            Price = price;
            IsFree = isFree;
            NumberAllRooms++;
            NumberOfRoom = NumberAllRooms;
        }
        public Room()
        {

        }
        public void AddMonth(string month)
        {
            MonthList.Add(month);
            if (MonthList.Count == 6)
                IsFree = false;
        }
        public void DeleteMonth(string month)
        {
            MonthList.Remove(month);
            if (MonthList.Count != 6)
                IsFree = true;
        }
        public override string ToString()
        {
            return "№" + NumberOfRoom + " Кол-во спальных мест: " + NumberOfBerths + ". Цена: " + Price + ". Занятых месяцев: " + MonthList.Count;
        }
    }
}
