using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB6.Classes;
using System.Threading; //Потоки
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace SPZLAB6
{
    public partial class Form1 : Form
    {
        public Hotel hotel { get; set; }

        private Thread myThread;  // Поток
        public delegate void BookRoomDel();
        public BookRoomDel myDelegate;

        public Form1()
        {
            InitializeComponent();
            hotel = new Hotel();
            myDelegate = new BookRoomDel(BookRoom);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoomsLbx.Items.Clear();
            RoomsLbx.Items.AddRange(hotel.RoomList.ToArray());
        }

        private void BookBtn_Click(object sender, EventArgs e) //Бронировать номер
        {
            if(IsHolidayCbx.Checked == true)
            {
                Room someRoom = (Room)RoomsLbx.SelectedItem;
                if (someRoom.IsFree == true)
                {
                    myThread = new Thread(new ThreadStart(ThreadFunction)); // Создание потока
                    myThread.Start();
                }
                else
                    MessageBox.Show("Все месяцы заняты!");
            }
        }
        private void ThreadFunction()
        {
            MyThreadClass myThreadClassObject = new MyThreadClass(this);
            myThreadClassObject.Run();
        }
        private void BookRoom()//Бронировать номер
        {
            var bookRoomForm = new BookRoom((Room)RoomsLbx.SelectedItem);
            bookRoomForm.StartPosition = FormStartPosition.CenterParent;
            if (bookRoomForm.ShowDialog() == DialogResult.OK)
            {
                hotel.RoomList[RoomsLbx.SelectedIndex] = bookRoomForm.room;
                RoomsLbx.Items.Clear();
                RoomsLbx.Items.AddRange(hotel.RoomList.ToArray());
            }
            var count = (from t in hotel.RoomList where (t.MonthList.Count > 0) select t).Count();
            if (count >= 10)
            {
                IsHolidayCbx.Checked = false;
                IsHolidayCbx.Enabled = false;
            }
        }
        public class MyThreadClass
        {
            Form1 myFormControl1;
            public MyThreadClass(Form1 myForm)
            {
                myFormControl1 = myForm;
            }
            public void Run()
            {
                myFormControl1.Invoke(myFormControl1.myDelegate);
            }
        }

        private void FreeRoomBtn_Click(object sender, EventArgs e) // Освободить комнату 
        {
            var freeRoomForm = new FreeRoom((Room)RoomsLbx.SelectedItem);
            freeRoomForm.StartPosition = FormStartPosition.CenterParent;
            if (freeRoomForm.ShowDialog() == DialogResult.OK)
            {
                hotel.RoomList[RoomsLbx.SelectedIndex] = freeRoomForm.room;
                RoomsLbx.Items.Clear();
                RoomsLbx.Items.AddRange(hotel.RoomList.ToArray());
            }
            var count = (from t in hotel.RoomList where (t.MonthList.Count > 0) select t).Count();
            if (count < 10)
                IsHolidayCbx.Enabled = true;
        }

        private void SaveToXMLBtn_Click(object sender, EventArgs e) // XML
        {
            XmlSerializer ser = new XmlSerializer(typeof(Hotel));
            TextWriter writer = new StreamWriter("Report.xml");
            ser.Serialize(writer, hotel);
            writer.Close();
        }

        private void ShowXMLBtn_Click(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader("Report.xml");
            string text = reader.ReadToEnd();
            reader.Close();
            XMLTextTbx.ScrollBars = ScrollBars.Vertical;
            XMLTextTbx.Text = text;
        }
    }
}
