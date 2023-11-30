using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotDump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tbSlotNum.Text = "A-1";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tbSlotNum.Text = "A-2";
        }

        private void tbSlotNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSlotNum.Text == "A-1")
            {
                A1.BackColor = Color.Red;
                A1.Enabled = false;
            }
            else if (tbSlotNum.Text == "A-2") 
            {
                A2.BackColor = Color.Red;
                A2.Enabled = false;
            }

            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode((tbPlateNum.Text + " | " + tbSlotNum.Text + " | " + DateTime.Now.ToString("yyyy-MM-dd HH:mm")), QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);

            //DISPLAY PRINT RECEIPT - LOADING SCREEN

            PrintReceipt pr = new PrintReceipt();
            pr.image = QRcode.GetGraphic(50);
            pr.plateNum = tbPlateNum.Text;
            pr.slotNum = tbSlotNum.Text;
            tbSlotNum.Clear();
            tbPlateNum.Clear();
            pr.ShowDialog();

            
        }
    }
}
