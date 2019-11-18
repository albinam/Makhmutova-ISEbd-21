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
        MultiLevelMilitaryBase military_base;
        /// <summary>         
        /// Количество уровней-парковок         
        /// </summary>         
        private const int countLevel = 5;
        /// <summary>         
        /// Форма для добавления        
        /// </summary>         
        FormArmorCarConfig form; 
        public FormMilitaryBase()
        {
            InitializeComponent();
            military_base = new MultiLevelMilitaryBase(countLevel, pictureBoxMilitaryBase.Width, pictureBoxMilitaryBase.Height);
            //заполнение listBox            
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>         
        /// Метод отрисовки парковки         
        /// </summary>         
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)                
                Bitmap bmp = new Bitmap(pictureBoxMilitaryBase.Width, pictureBoxMilitaryBase.Height);
                Graphics gr = Graphics.FromImage(bmp);
                military_base[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxMilitaryBase.Image = bmp;
            }
        }
        /// <summary>        
        /// Обработка нажатия кнопки "Забрать"       
        /// </summary>       
        /// <param name="sender"></param>        
        /// <param name="e"></param>  
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var armor_car = military_base[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
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
        /// <summary>         
        /// Метод обработки выбора элемента на listBoxLevels         
        /// </summary>         
        /// <param name="sender"></param>        
        /// <param name="e"></param>       
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>        
        /// Обработка нажатия кнопки "Добавить автомобиль"        
        /// </summary>        
        /// <param name="sender"></param>        
        /// <param name="e"></param>        
        private void buttonSetArmorCar_Click(object sender, EventArgs e)
        {
            form = new FormArmorCarConfig();
            form.AddEvent(AddArmorCar);
            form.Show();
        } 
        /// <summary>         
        /// Метод добавления машины        
        /// </summary>         
        /// <param name="car"></param>         
        private void AddArmorCar(ITransport armor_car)         
        {            
        if (armor_car != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = military_base[listBoxLevels.SelectedIndex] + armor_car;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}
