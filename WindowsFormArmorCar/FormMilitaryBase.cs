using NLog;
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
        private Logger logger;
        public FormMilitaryBase()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                if (maskedTextBoxPlace.Text != "")
                {
                    try
                    {
                        var armor_car = military_base[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        armor_car.SetPosition(5, 5, pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                        armor_car.DrawArmorCar(gr);
                        pictureBoxTakeArmorCar.Image = bmp;
                        logger.Info("Изъят автомобиль " + armor_car.ToString() + " с места " + maskedTextBoxPlace.Text);
                        Draw();
                    }
                    catch (MilitaryBaseNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Не найдено");
                        Bitmap bmp = new Bitmap(pictureBoxTakeArmorCar.Width, pictureBoxTakeArmorCar.Height);
                        pictureBoxTakeArmorCar.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Неизвестная ошибка");
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
                try
                {
                    int place = military_base[listBoxLevels.SelectedIndex] + armor_car;
                    logger.Info("Добавлен автомобиль " + armor_car.ToString() + " на место " + place); Draw();
                }
                catch (MilitaryBaseOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Переполнение");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    military_base.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                try
                {
                    military_base.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (MilitaryBaseOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
            Draw();
        }
        private void сохранитьУровеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (military_base.SaveLevel(listBoxLevels.SelectedIndex, saveFileDialog.FileName))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                    }
                }
                catch (MilitaryBaseOccupiedPlaceException ex)
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");

                }
            }
        }
        private void загрузитьУровеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (military_base.LoadLevel(listBoxLevels.SelectedIndex, openFileDialog.FileName))
                    {
                        MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                        logger.Info("Загружено из файла " + openFileDialog.FileName);
                    }
                }
                catch (MilitaryBaseOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
                Draw();
            }
        }
    }
}
