using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // luetaan kokonaisluku tekstikentästä
            int luku1 = int.Parse(textBoxLuku1.Text);
            int luku2 = int.Parse(textBoxLuku2.Text);

            int tulos = luku1 + luku2;

            // ToString muuttaa tekstiksi
            textBoxTulos.Text = tulos.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // luetaan kokonaisluku tekstikentästä
            int luku1 = int.Parse(textBoxLuku1.Text);
            int luku2 = int.Parse(textBoxLuku2.Text);

            int tulos = luku1 - luku2;

            // ToString muuttaa tekstiksi
            textBoxTulos.Text = tulos.ToString();
        }
    }
}
