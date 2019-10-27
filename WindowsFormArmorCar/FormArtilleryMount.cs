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
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new ArtilleryMount(100, 300, Color.Green,
           Color.Black,20, true, false);
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
    }
}
