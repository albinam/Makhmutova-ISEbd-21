﻿using System;
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
    public partial class FormMilitaryBase : Form
    {
        MilitaryBase<ITransport> military_base;

        public FormMilitaryBase()
        {
            InitializeComponent();
            military_base = new MilitaryBase<ITransport>(15, pictureBoxMilitaryBase.Width, pictureBoxMilitaryBase.Height);
            Draw();
        }
        /// <summary>         
        /// Метод отрисовки парковки         
        /// </summary>         
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMilitaryBase.Width, pictureBoxMilitaryBase.Height);
            Graphics gr = Graphics.FromImage(bmp);
            military_base.Draw(gr);
            pictureBoxMilitaryBase.Image = bmp;
        }
        /// <summary> 
        /// Обработка нажатия кнопки "Припарковать бронированную машину"         
        /// </summary>         
        /// <param name="sender"></param>       
        /// <param name="e"></param>        
        private void buttonSetArmorCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var armor_car = new ArmorCar(100, 1000, dialog.Color);
                int place = military_base + armor_car;
                Draw();
            }
        }
        /// <summary>         
        /// Обработка нажатия кнопки "Припарковать арт.установку"        
        /// </summary>         
        /// <param name="sender"></param>        
        /// <param name="e"></param>        
        private void buttonSetArtilleryMount_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var artilleru_mount = new ArtilleryMount(100, 1000, dialog.Color, dialogDop.Color, 20, true, false);

                    int place = military_base + artilleru_mount;
                    Draw();
                }
            }
        }
        /// <summary>        
        /// Обработка нажатия кнопки "Забрать"       
        /// </summary>       
        /// <param name="sender"></param>        
        /// <param name="e"></param>  
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var armor_car = military_base - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (armor_car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    armor_car.SetPosition(5, 5, pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                    armor_car.DrawArmorCar(gr);
                    pictureBoxTakeArmorCar.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                    pictureBoxTakeArmorCar.Image = bmp;
                }
                Draw();
            }
        }      
    }
}
