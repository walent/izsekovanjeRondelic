using CircleInRectangleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzsekovanjeRondelic
{
    public partial class Form1 : Form
    {
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CircleInRectangle cir = new CircleInRectangle();
            result = cir.numberOfSlugs(257, 157, 1.7, 1);
            Console.WriteLine(result);
        }
    }
}
