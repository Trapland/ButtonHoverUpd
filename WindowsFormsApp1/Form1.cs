using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point p = new Point();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            p.X = (r.Next(this.Width - button1.Width));
            p.Y = (r.Next(this.Height - button1.Height));
            button1.Location = p;
        }
    }
}
