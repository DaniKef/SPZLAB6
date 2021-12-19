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
    public partial class FreeRoom : Form
    {
        public Room room { get; set; }
        public FreeRoom(Room roomSend)
        {
            InitializeComponent();
            room = new Room();
            room = roomSend;
        }

        private void FreeRoomBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MonthCbx.SelectedItem.ToString()))
            {
                room.DeleteMonth(MonthCbx.SelectedItem.ToString());
            }
            else throw new Exception("Ввести корректно!");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
