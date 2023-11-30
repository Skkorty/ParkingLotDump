using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotDump
{
    public partial class PrintReceipt : Form
    {
        public Image image;
        public string slotNum, plateNum;
        public PrintReceipt()
        {
            InitializeComponent();
        }

        private void lblPlateNum_Click(object sender, EventArgs e)
        {

        }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            ReceiptQR.Image = image;
            lblSlotNum.Text = slotNum;
            lblPlateNum.Text = plateNum;
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
