using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormArmorCar
{
    public partial class FormArtilleryMount : Form
    {
        private ArtilleryMount car;
      
        public FormArtilleryMount()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            car = new ArtilleryMount(100, 300, Color.Green,
           Color.Black,20, true, false,Guns.Two);
            car.SetPosition(50, 50, pictureBoxArtilleryMount.Width,
           pictureBoxArtilleryMount.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxArtilleryMount.Width, pictureBoxArtilleryMount.Height);
            Graphics gr = Graphics.FromImage(bmp);
         
            car.DrawArmorCar(gr);
            pictureBoxArtilleryMount.Image = bmp;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
              

            }
            Draw();
        }
        /*private Guns gun;
        private void button1_Click(object sender, EventArgs e)
        {
            gun=Guns.One;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            gun = Guns.Two;
        }

            private void button3_Click(object sender, EventArgs e)
        {
            gun = Guns.Three;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n;
            n = (int)numericUpDown1.Value;
            if (n == 1)
            {
                gun = Guns.One;
            }
            if (n == 2)
            {
                gun = Guns.Two;
            }
            if (n == 3)
            {
                gun = Guns.Three;
            }
        }*/
    }
}
