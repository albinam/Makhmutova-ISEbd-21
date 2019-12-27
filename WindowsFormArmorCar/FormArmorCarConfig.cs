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
    public partial class FormArmorCarConfig : Form
    {
        ITransport armor_car = null;
        private event armor_carDelegate eventAddArmorCar;
        public FormArmorCarConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawArmorCar()
        {
            if (armor_car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxArmorCar.Width, pictureBoxArmorCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                armor_car.SetPosition(25, 25, pictureBoxArmorCar.Width, pictureBoxArmorCar.Height);
                armor_car.DrawArmorCar(gr); pictureBoxArmorCar.Image = bmp;
            }
        }
        /// <summary>        
        /// Добавление события         
        /// </summary>        
        /// <param name="ev"></param> 
        public void AddEvent(armor_carDelegate ev)
        {
            if (eventAddArmorCar == null)
            {
                eventAddArmorCar = new armor_carDelegate(ev);
            }
            else
            {
                eventAddArmorCar += ev;
            }
        }
        /// Отправляем цвет с панели         
        /// </summary>         
        /// <param name="sender"></param>        
        //// <param name="e"></param>         
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>        
        /// Проверка получаемой информации (ее типа на соответствие требуемому)        
        /// </summary>         
        //// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>         
        /// Принимаем основной цвет        
        /// </summary>        
        /// <param name="sender"></param>        
        /// <param name="e"></param> 
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (armor_car != null)
            {
                armor_car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawArmorCar();
            }
        }
        /// <summary>         
        /// Принимаем дополнительный цвет        
        /// </summary>        
        /// <param name="sender"></param>        
        /// <param name="e"></param>         
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (armor_car != null)
            {
                if (armor_car is ArtilleryMount)
                {
                    (armor_car as ArtilleryMount).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawArmorCar();
                }
            }
        }
        /// <summary>        
        /// Передаем информацию при нажатии на Label      
        /// </summary>       
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void labelArmorCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelArmorCar.DoDragDrop(labelArmorCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>        
        /// Передаем информацию при нажатии на Label      
        /// </summary>       
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void labelArtilleryMount_MouseDown(object sender, MouseEventArgs e)
        {
            labelArtilleryMount.DoDragDrop(labelArtilleryMount.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>        
        /// Передаем информацию при нажатии на Label      
        /// </summary>       
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void panelArmorCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>        
        /// Действия при приеме перетаскиваемой информации         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>   
        private void panelArmorCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронированная машина":
                    armor_car = new ArmorCar(100, 500, Color.White);
                    break;
                case "Самоходная артиллерейская установка":
                    armor_car = new ArtilleryMount(100, 500, Color.White, Color.Black, 70, true, false, Guns.Three, 0);
                    break;
            }
            DrawArmorCar();
        }
        /// <summary>         
        /// Добавление машины        
        /// </summary>      
        /// <param name="sender"></param>        
        /// <param name="e"></param>        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddArmorCar?.Invoke(armor_car);
            Close();
        }
        private void labelSimpleGuns_MouseDown(object sender, MouseEventArgs e)
        {
            labelSimpleGuns.DoDragDrop(labelSimpleGuns.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelGunsWithPattern_MouseDown(object sender, MouseEventArgs e)
        {
            labelGunsWithPattern.DoDragDrop(labelGunsWithPattern.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelGunsWithAngle_MouseDown(object sender, MouseEventArgs e)
        {
            labelGunsWithAngle.DoDragDrop(labelGunsWithAngle.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelGunsType_DragDrop(object sender, DragEventArgs e)
        {
            if (armor_car != null)
            {
                if (armor_car is ArtilleryMount)
                {
                    switch (e.Data.GetData(DataFormats.Text).ToString())
                    {
                        case "Простое орудие":
                            (armor_car as ArtilleryMount).SetGunType(0);
                            break;
                        case "Орудие с рисунком":
                            (armor_car as ArtilleryMount).SetGunType(1);
                            break;
                        case "Орудие под углом":
                            (armor_car as ArtilleryMount).SetGunType(2);
                            break;
                    }
                    DrawArmorCar();
                }
            }
        }
        private void labelGunsType_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
