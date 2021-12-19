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


namespace SPZLAB6
{
    public partial class BookRoom : Form
    {
        public Room room { get; set; }
        public BookRoom(Room roomSend)
        {
            InitializeComponent();
            room = new Room();
            room = roomSend;
        }

        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DaysTbx.Text) && !string.IsNullOrEmpty(NameTbx.Text) &&
                !string.IsNullOrEmpty(SurnameTbx.Text) && !string.IsNullOrEmpty(MonthCbx.SelectedItem.ToString()) && !room.MonthList.Contains(MonthCbx.SelectedItem.ToString()))
            {
                room.AddMonth(MonthCbx.SelectedItem.ToString());
            }
            else
                throw new Exception("Месяц занят. Введите данные корректно.");

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
