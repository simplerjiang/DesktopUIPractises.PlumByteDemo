using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUIPractises.PlumByteDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCOverview uC = new UCOverview();
            uC.Dock = DockStyle.Fill;
            foreach (Control item in panelController.Controls)
            {
                if (item is UCOverview)
                {
                    panel1.Controls.Remove(item);
                    break;
                }
            }
            panelController.Controls.Add(uC);
        }
    }
}
